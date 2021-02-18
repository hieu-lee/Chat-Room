using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Room : Form
    {
        public IMongoDatabase controldb { get; set; }
        public IMongoCollection<Account> controlAccounts { get; set; }
        public byte[] avatar { get; set; }
        public bool adming { get; set; }
        public string label { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public IMongoDatabase database { get; set; }
        public string Id { get; set; }

        public bool InRoom = true;
        public List<Account> roomAccounts;
        public bool noti = true;
        private bool typing = false;
        private FilterDefinition<Account> filterTyping1;
        private FilterDefinition<Message> filter = Builders<Message>.Filter.Eq("received", false);
        private FilterDefinition<Message> filterDelete = Builders<Message>.Filter.Eq("received", true);
        private UpdateDefinition<Account> updateTyping1 = Builders<Account>.Update.Set("typing", true);
        private UpdateDefinition<Account> updateTyping2 = Builders<Account>.Update.Set("typing", false);
        private UpdateDefinition<Account> updateConnection = Builders<Account>.Update.Set("connected", true);
        private UpdateDefinition<Account> updateDisconnection = Builders<Account>.Update.Set("connected", false);
        private UpdateDefinition<Message> update = Builders<Message>.Update.Set("received", true);
        private HashSet<string> receivedMessages = new HashSet<string>();
        private IMongoCollection<Message> myMessages;
        private IMongoCollection<Message> messages;
        public IMongoCollection<Account> accounts;
        private Emoji emoji = new Emoji();

        public Room()
        {
            InitializeComponent();
            for (int i = 0; i < 140; i++)
            {
                var icon = new EmojiIcon(emoji.Emojis[i]) { textBox = this.textBox };
                int n = (int)Math.Floor((decimal)(i / 14));
                icon.Location = new Point(32 * (i % 14), 32 * n);
                emojiContainer.Controls.Add(icon);
            }
        }


        private byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private async void Room_Load(object sender, EventArgs e)
        {
            this.Text = $"{name}";
            label1.Text = label;
            try
            {
                messages = database.GetCollection<Message>("messages");
                var task1 = messages.Find(s => s.time > DateTime.Now.AddDays(-2)).ToListAsync();
                filterTyping1 = Builders<Account>.Filter.Eq("_id", username);
                accounts = database.GetCollection<Account>("accounts");
                var task2 = accounts.UpdateOneAsync(filterTyping1, updateConnection);
                myMessages = database.GetCollection<Message>($"{username} receives");
                var task3 = myMessages.UpdateManyAsync(Builders<Message>.Filter.Empty, update);
                List<Message> history = await task1;
                history.Sort((a, b) => a.time.CompareTo(b.time));
                foreach (Message message in history)
                {
                    if (message.image != null)
                    {
                        Image img = byteArrayToImage(message.image);
                        Clipboard.SetImage(img);
                        chatArea.ReadOnly = false;
                        chatArea.AppendText($"\n{message.username}: ");
                        chatArea.Paste();
                        chatArea.AppendText("\n");
                        chatArea.ReadOnly = true;
                    }
                    else
                    {
                        chatArea.AppendText("\n" + message.ToString() + "\n");
                    }   
                }
                await task2;
                await task3;
                timer1.Start();
                Thread t = new Thread(OnlineCheck);
                t.IsBackground = true;
                t.Start();
                timer2.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error");
                this.Close();
            }
        }

        private void Notification(string sender)
        {
            if (noti && this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.ShowBalloonTip(1000, "New message", $"You have just received a new message from {sender}", ToolTipIcon.Info);
            }
        }

        private async void UpdateChat()
        {
            List<Message> unreceivedMessages = myMessages.Find(filter).ToList();
            foreach (Message m in unreceivedMessages)
            {
                try
                {
                    Notification(m.username);
                }
                catch(Exception) { return; }
                if (!receivedMessages.Contains(m.Id.ToString()))
                {
                    var messageFilter = Builders<Message>.Filter.Eq("_id", m.Id);
                    receivedMessages.Add(m.Id.ToString());
                    var task = myMessages.UpdateOneAsync(messageFilter, update);
                    if (m.image != null)
                    {
                        try
                        {
                            Image img = byteArrayToImage(m.image);
                            Clipboard.SetImage(img);
                            chatArea.ReadOnly = false;
                            chatArea.AppendText($"\n{m.username}: ");
                            chatArea.Paste();
                            chatArea.AppendText("\n");
                            chatArea.ReadOnly = true;
                        }
                        catch(Exception) { return; }
                    }
                    else
                    {
                        try
                        {
                            chatArea.AppendText("\n" + m.ToString() + "\n");
                        }
                        catch(Exception) { return; }
                    }
                    await task;
                }
            }
        }

        private async void DeclareTyping()
        {
            if (!string.IsNullOrWhiteSpace(this.textBox.Text) && (this.textBox.Text != "Type a message..."))
            {
                if (!typing)
                {
                    typing = true;
                    await accounts.UpdateOneAsync(filterTyping1, updateTyping1);
                }
            }
            else
            {
                if (typing)
                {
                    typing = false;
                    await accounts.UpdateOneAsync(filterTyping1, updateTyping2);
                }
            }
        }

        private void TypingCheck()
        {
            var someone = accounts.Find(s => s.typing == true && s.username != username).FirstOrDefault();
            if (someone != null)
            { 
                try
                {
                    label2.Text = "Someone is typing...";
                }
                catch (Exception) { return; }
            }
            else
            {
                try
                {
                    label2.Text = "";
                }
                catch (Exception) { return; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread t1 = new Thread(UpdateChat);
            Thread t2 = new Thread(DeclareTyping);
            Thread t3 = new Thread(TypingCheck);
            t1.IsBackground = true;
            t2.IsBackground = true;
            t3.IsBackground = true;
            t1.SetApartmentState(ApartmentState.STA);
            t2.SetApartmentState(ApartmentState.STA);
            t3.SetApartmentState(ApartmentState.STA);
            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void SendMessage(object img)
        {
            Image image = (Image)img;
            string text = textBox.Text;
            Message message;
            textBox.Text = string.Empty;
            if (image != null)
            {
                message = new Message() { username = username, content = "", received = false, time = DateTime.Now, image = imageToByteArray(image) };
                chatArea.ReadOnly = false;
                chatArea.AppendText($"\n{username}: ");
                chatArea.Paste();
                chatArea.AppendText("\n");
                chatArea.ReadOnly = true;
            }
            else
            {
                message = new Message() { username = username, content = text, received = false, time = DateTime.Now, image = null };
                chatArea.AppendText("\n" + message.ToString() + "\n");
            }
            var myAcc = accounts.Find(s => s.username == username).FirstOrDefault();
            var contactList = myAcc.contacts;
            var tasks = new List<Task>();
            Parallel.ForEach(contactList, user =>
            {
                var destination = database.GetCollection<Message>($"{user} receives");
                var t = destination.InsertOneAsync(message);
                tasks.Add(t);
            });
            var LastTask = messages.InsertOneAsync(message);
            Parallel.ForEach(tasks, async task =>
            {
                await task;
            });
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    Thread t = new Thread(SendMessage);
                    t.Start(null);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                Thread t = new Thread(SendMessage);
                t.Start(null);
            }
        }

        private void buttonSend_MouseHover(object sender, EventArgs e)
        {
            buttonSend.IconColor = Color.HotPink;
        }

        private void buttonSend_MouseLeave(object sender, EventArgs e)
        {
            buttonSend.IconColor = Color.DimGray;
        }

        private async void Room_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (InRoom)
            {
                var task1 = accounts.UpdateOneAsync(filterTyping1, updateDisconnection);
                var task2 = accounts.UpdateOneAsync(filterTyping1, updateTyping2);
                var task3 = myMessages.DeleteManyAsync(filterDelete);
                await task1;
                await task2;
                await task3;
            }
        }

        private void OnlineCheck()
        {
            Thread t = new Thread(() =>
            {
                roomAccounts = accounts.Find(s => true).ToList();
            });
            t.Start();
            var c = accounts.CountDocuments(s => s.connected);
            if (c == 1)
            {
                try
                {
                    label3.Text = "Online: 1 user";
                }
                catch(Exception) { return; }
            }
            else
            {
                try
                {
                    label3.Text = $"Online: {c} users";
                }
                catch(Exception) { return; }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(OnlineCheck);
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                long length = new System.IO.FileInfo(open.FileName).Length;
                if (length > 5500000)
                {
                    MessageBox.Show("The image is too large");
                    return;
                }
                else
                {
                    var img = Image.FromFile(open.FileName);
                    var width = (int)Math.Ceiling((decimal)img.Width / 300);
                    var height = (int)Math.Ceiling((decimal)img.Height / 300);
                    var c = Math.Max(width, height);
                    width = (int)Math.Floor((decimal)img.Width / c);
                    height = (int)Math.Floor((decimal)img.Height / c);
                    img = ResizeImage(img, width, height);
                    Clipboard.SetImage(img);
                    Thread t = new Thread(SendMessage);
                    t.Start(img);
                }
            }
        }

        private void buttonImage_MouseHover(object sender, EventArgs e)
        {
            buttonImage.IconColor = Color.HotPink;
        }

        private void buttonImage_MouseLeave(object sender, EventArgs e)
        {
            buttonImage.IconColor = Color.DimGray;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            emojiContainer.Visible = !(emojiContainer.Visible);
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.HotPink;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.DimGray;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            var onlineUsers = new InfoShow() { roomAccounts = roomAccounts, infoType = "users", accounts = controlAccounts, room = this};
            onlineUsers.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to change the room's avatar?", "Avatar change", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    var img = Image.FromFile(open.FileName);
                    pictureBox1.Image = img;
                }
            }
        }

        private void infoButton_MouseHover(object sender, EventArgs e)
        {
            infoButton.IconColor = Color.HotPink;
        }

        private void infoButton_MouseLeave(object sender, EventArgs e)
        {
            infoButton.IconColor = Color.DimGray;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
