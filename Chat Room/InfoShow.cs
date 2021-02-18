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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class InfoShow : Form
    {
        public IMongoCollection<Account> accounts { get; set; } = null;
        public string infoType { get; set; }
        public List<Account> roomAccounts { get; set; } = null;
        public List<ChatRoom> publicRooms { get; set; } = null;
        public Room room;

        public InfoShow()
        {
            InitializeComponent();
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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

        private void OnlineUsers_Load(object sender, EventArgs e)
        {
            var c = 1;
            try
            {
                if (room.noti)
                {
                    checkBox1.Checked = true;
                    checkBox1.CheckState = CheckState.Checked;
                }
                else if (!room.noti)
                {
                    checkBox2.Checked = true;
                    checkBox2.CheckState = CheckState.Checked;
                }
            }
            catch (NullReferenceException)
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                label2.Text = "";
                iconButton2.Visible = false;
            }

           
            if (infoType == "users")
            {
                label1.Text = "Current room's users";
                var onlineAccsSet = new HashSet<string>();
                Parallel.ForEach(roomAccounts, acc =>
                {
                    onlineAccsSet.Add(acc.username);
                });
                roomAccounts = accounts.Find(s => onlineAccsSet.Contains(s.username)).ToList();
                foreach (Account acc in roomAccounts)
                {
                    richTextBox1.AppendText($"\n{c}. ");
                    var img = byteArrayToImage(acc.avatar);
                    img = ResizeImage(img, 53, 48);
                    Clipboard.SetImage(img);
                    richTextBox1.ReadOnly = false;
                    richTextBox1.Paste();
                    richTextBox1.ReadOnly = true;
                    if (acc.connected)
                    {
                        richTextBox1.AppendText($" {acc.username} (online)\n");
                    }
                    else
                    {
                        richTextBox1.AppendText($" {acc.username} (offline)\n");
                    }
                    c++;
                }
                richTextBox1.Text.Trim();
            }
            else if (infoType == "rooms")
            {
                label1.Text = "Currently pulbic rooms";
                foreach (ChatRoom room in publicRooms)
                {
                    richTextBox1.Text += $" {c}. #{room.Id}: {room.name}\n";
                    c++;
                }
            }
            
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            room.noti = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            room.noti = true;
        }

        private async void LeaveRoom()
        {
            var username = room.username;
            var accounts = room.controldb.GetCollection<Account>("accounts");
            var filteracc = Builders<Account>.Filter.Eq("_id", username);
            var mycontactsTask = room.accounts.Find(s => s.username != room.username).ToListAsync();
            var myaccTask = accounts.Find(filteracc).FirstOrDefaultAsync();
            room.InRoom = false;
            room.timer1.Stop();
            room.timer2.Stop();
            var controlAccs = room.controlAccounts;
            var mycontacts = await mycontactsTask;
            Parallel.ForEach(mycontacts, acc =>
            {
                var filter = Builders<Account>.Filter.Eq("_id", acc.username);
                acc.contacts.Remove(username);
                var update = Builders<Account>.Update.Set("contacts", acc.contacts);
                room.accounts.UpdateOneAsync(filter, update);
            });
            var task1 = room.database.DropCollectionAsync($"{username} receives");
            var task2 = room.accounts.DeleteOneAsync(filteracc);
            var myacc = await myaccTask;
            myacc.rooms.Remove(room.Id);
            var updateacc = Builders<Account>.Update.Set("rooms", myacc.rooms);
            var task3 = accounts.FindOneAndUpdateAsync(filteracc, updateacc);
            this.Hide();
            await task1;
            await task2;
            await task3;
            room.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to leave the room?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                LeaveRoom();
            }
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.HotPink;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.DimGray;
        }
    }
}
