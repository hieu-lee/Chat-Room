using Chat_Room.ChatItems;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class NewRoom : Form
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

        public string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "phamleha";
                string secretkey = "hiulebeo";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public string Decrypt(string textToDecrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "phamleha";
                string privatekey = "hiulebeo";
                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(privatekey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        private string Base64StringEncode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        private string Base64StringDecode(string encodedString)
        {
            var bytes = Convert.FromBase64String(encodedString);

            var decodedString = Encoding.UTF8.GetString(bytes);

            return decodedString;
        }

        public NewRoom()
        {
            InitializeComponent();
            for (int i = 0; i < 140; i++)
            {
                var icon = new EmojiIcon(emoji.Emojis[i]) { textBox = this.textBox };
                icon.Location = new Point(32*i, 0);
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
                        AddImage(img, message.username);
                    }
                    else
                    {
                        message.content = Decrypt(message.content);
                        message.content = Base64StringDecode(message.content);
                        AddMessage(message.content, message.username);
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
                if (!receivedMessages.Contains(m.Id.ToString()))
                {
                    try
                    {
                        Notification(m.username);
                    }
                    catch (Exception) { return; }
                    var messageFilter = Builders<Message>.Filter.Eq("_id", m.Id);
                    receivedMessages.Add(m.Id.ToString());
                    var task = myMessages.UpdateOneAsync(messageFilter, update);
                    Task task1;
                    if (m.image != null)
                    {
                        try
                        {
                            Image img = byteArrayToImage(m.image);
                            task1 = Task.Factory.StartNew(() => AddImageIncoming(img, m.username));
                        }
                        catch (Exception) { return; }
                    }
                    else
                    {
                        try
                        {
                            m.content = Base64StringDecode(m.content);
                            task1 = Task.Factory.StartNew(() => AddIncoming(m.content, m.username));
                        }
                        catch (Exception) { return; }
                    }
                    await task;
                    await task1;
                }
            }
        }

        private void AddImage(Image image, string username)
        {
            if (username == this.username)
            {
                AddImageOutgoing(image);
            }
            else
            {
                AddImageIncoming(image, username);
            }
        }

        private void AddImageOutgoing(Image image)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    var width = (int)Math.Ceiling((decimal)image.Width / 350);
                    var height = (int)Math.Ceiling((decimal)image.Height / 350);
                    var c = Math.Max(width, height);
                    width = (int)Math.Floor((decimal)image.Width / c);
                    height = (int)Math.Floor((decimal)image.Height / c);
                    var imageZip = ResizeImage(image, width, height);
                    var piccontainer = new Panel();
                    var pic = new PicSent() { Image = imageZip, Size = imageZip.Size, ImageOriginal = image };
                    pic.Width += 10;
                    piccontainer.Height = pic.Height + 10;
                    piccontainer.Controls.Add(pic);
                    pic.Dock = DockStyle.Right;
                    panel3.Controls.Add(piccontainer);
                    piccontainer.Dock = DockStyle.Top;
                    piccontainer.BringToFront();
                    ScrollToBottom();
                });
            }
            else
            {
                var width = (int)Math.Ceiling((decimal)image.Width / 350);
                var height = (int)Math.Ceiling((decimal)image.Height / 350);
                var c = Math.Max(width, height);
                width = (int)Math.Floor((decimal)image.Width / c);
                height = (int)Math.Floor((decimal)image.Height / c);
                var imageZip = ResizeImage(image, width, height);
                var piccontainer = new Panel();
                var pic = new PicSent() { Image = imageZip, Size = imageZip.Size, ImageOriginal = image };
                pic.Width += 10;
                piccontainer.Height = pic.Height + 10;
                piccontainer.Controls.Add(pic);
                pic.Dock = DockStyle.Right;
                panel3.Controls.Add(piccontainer);
                piccontainer.Dock = DockStyle.Top;
                piccontainer.BringToFront();
                ScrollToBottom();
            }
        }

        private void AddImageIncoming(Image image, string user)
        {
            
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    var width = (int)Math.Ceiling((decimal)image.Width / 350);
                    var height = (int)Math.Ceiling((decimal)image.Height / 350);
                    var c = Math.Max(width, height);
                    width = (int)Math.Floor((decimal)image.Width / c);
                    height = (int)Math.Floor((decimal)image.Height / c);
                    var imageZip = ResizeImage(image, width, height);
                    var piccontainer = new Panel();
                    var pic = new PicSent() { Image = imageZip, Size = imageZip.Size, ImageOriginal = image };
                    var username = new Label() { Text = user, Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))) };
                    username.Width -= 60;
                    piccontainer.Height = pic.Height + 10;
                    piccontainer.Controls.Add(pic);
                    username.Dock = DockStyle.Left;
                    piccontainer.Controls.Add(username);
                    pic.Dock = DockStyle.Left;
                    panel3.Controls.Add(piccontainer);
                    piccontainer.Dock = DockStyle.Top;
                    piccontainer.BringToFront();
                    ScrollToBottom();
                });
            }
            else
            {
                var width = (int)Math.Ceiling((decimal)image.Width / 350);
                var height = (int)Math.Ceiling((decimal)image.Height / 350);
                var c = Math.Max(width, height);
                width = (int)Math.Floor((decimal)image.Width / c);
                height = (int)Math.Floor((decimal)image.Height / c);
                var imageZip = ResizeImage(image, width, height);
                var piccontainer = new Panel();
                var pic = new PicSent() { Image = imageZip, Size = imageZip.Size, ImageOriginal = image };
                var username = new Label() { Text = user, Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))) };
                username.Width -= 60;
                piccontainer.Height = pic.Height + 10;
                piccontainer.Controls.Add(pic);
                username.Dock = DockStyle.Left;
                piccontainer.Controls.Add(username);
                pic.Dock = DockStyle.Left;
                panel3.Controls.Add(piccontainer);
                piccontainer.Dock = DockStyle.Top;
                piccontainer.BringToFront();
                ScrollToBottom();
            }
        }

        private void AddMessage(string content, string username)
        {
            if (username == this.username)
            {
                AddOutgoing(content, username);
            }
            else
            {
                AddIncoming(content, username);
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
                    label3.Text = "Someone is typing...";
                }
                catch (Exception) { return; }
            }
            else
            {
                try
                {
                    label3.Text = "";
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
            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void AddIncoming(string message, string username)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    var bubblechat = new Panel();
                    var bubble = new Incoming() { username = username, content = message };
                    bubblechat.Height = bubble.Height;
                    bubblechat.Controls.Add(bubble);
                    bubble.Dock = DockStyle.Left;
                    panel3.Controls.Add(bubblechat);
                    bubblechat.BringToFront();
                    bubblechat.Dock = DockStyle.Top;
                    ScrollToBottom();
                });
            }
            else
            {
                var bubblechat = new Panel();
                var bubble = new Incoming() { username = username, content = message };
                bubblechat.Height = bubble.Height;
                bubblechat.Controls.Add(bubble);
                bubble.Dock = DockStyle.Left;
                panel3.Controls.Add(bubblechat);
                bubblechat.BringToFront();
                bubblechat.Dock = DockStyle.Top;
                ScrollToBottom();
            }
        }

        private void AddOutgoing(string message, string username)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    var bubblechat = new Panel();
                    var bubble = new Outgoing() { username = username, content = message };
                    bubblechat.Height = bubble.Height;
                    bubblechat.Controls.Add(bubble);
                    bubble.Dock = DockStyle.Right;
                    panel3.Controls.Add(bubblechat);
                    bubblechat.BringToFront();
                    bubblechat.Dock = DockStyle.Top;
                    ScrollToBottom();
                });
            }
            else
            {
                var bubblechat = new Panel();
                var bubble = new Outgoing() { username = username, content = message };
                bubblechat.Height = bubble.Height;
                bubblechat.Controls.Add(bubble);
                bubble.Dock = DockStyle.Right;
                panel3.Controls.Add(bubblechat);
                bubblechat.BringToFront();
                bubblechat.Dock = DockStyle.Top;
                ScrollToBottom();
            }
            
        }

        private async Task SendMessage(object img)
        {
            var taskFindAcc = this.accounts.Find(s => s.username == username).FirstOrDefaultAsync();
            Task task;
            Image image = (Image)img;
            string text = textBox.Text;
            Message message;
            if (image != null)
            {
                task = Task.Factory.StartNew(() => AddImageOutgoing(image));
                message = new Message() { username = username, content = null, received = false, time = DateTime.Now, image = imageToByteArray(image) };
            }
            else
            {
                textBox.Text = string.Empty;
                SendKeys.SendWait("{Backspace}");
                message = new Message() { username = username, content = text, received = false, time = DateTime.Now, image = null };
                task = Task.Factory.StartNew(() => AddOutgoing(text, message.username));
            }
            message.content = Base64StringEncode(message.content);
            message.content = Encrypt(message.content);
            var myAcc = await taskFindAcc;
            var contactList = myAcc.contacts;
            var tasks = new List<Task>();
            Parallel.ForEach(contactList, user =>
            {
                var destination = database.GetCollection<Message>($"{user} receives");
                var t = destination.InsertOneAsync(message);
                tasks.Add(t);
            });
            var LastTask = messages.InsertOneAsync(message);
            Parallel.ForEach(tasks, async t =>
            {
                await t;
            });
            await LastTask;
            await task;
        }

        private async void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (e.Modifiers & Keys.Shift) != Keys.Shift)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    await SendMessage(null);
                }
                e.SuppressKeyPress = true;
            }
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                await SendMessage(null);
            }
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

        private async void OnlineCheck()
        {
            var task = accounts.Find(s => true).ToListAsync();
            var c = accounts.CountDocuments(s => s.connected);
            if (c == 1)
            {
                try
                {
                    label2.Text = "Online: 1 user";
                }
                catch (Exception) { return; }
            }
            else
            {
                try
                {
                    label2.Text = $"Online: {c} users";
                }
                catch (Exception) { return; }
            }
            roomAccounts = await task;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(OnlineCheck);
            t.IsBackground = true;
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

        private async void buttonImage_Click(object sender, EventArgs e)
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
                    await SendMessage(img);
                }
            }
        }

        private void buttonImage_MouseHover(object sender, EventArgs e)
        {
            buttonImage.IconColor = Color.FromArgb(0, 140, 255);
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
            iconButton1.IconColor = Color.FromArgb(0, 140, 255);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.DimGray;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            var onlineUsers = new InfoShow() { roomAccounts = roomAccounts, infoType = "users", accounts = controlAccounts, room = this };
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
            infoButton.IconColor = Color.FromArgb(0, 140, 255);
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

        private void ScrollToBottom()
        {
            panel3.VerticalScroll.Value = panel3.VerticalScroll.Maximum;
            panel3.PerformLayout();
        }
    }
}