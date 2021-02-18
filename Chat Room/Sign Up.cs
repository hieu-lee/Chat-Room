using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Sign_Up : Form
    {
        public MongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<Account> accounts { get; set; }
        public Sign_Up()
        {
            InitializeComponent();
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

        private async void CreateAccount()
        {
            usernameBox.Text = usernameBox.Text.Trim();
            if (passwordBox.Text.Contains(' ') || passwordBox.Text.Length < 6)
            {
                MessageBox.Show("Your password is invalid", "Invalid password");
                return;
            }
            if (passwordBox.Text != confirmBox.Text)
            {
                MessageBox.Show("Your password is not correctly confirmed", "Incorrect password confirmation");
                return;
            }
            var check = usernameBox.Text.ToHashSet();
            foreach (char c in " !@#$%^&*();,.'")
            {
                if (check.Contains(c))
                {
                    MessageBox.Show("Your username is invalid", "Invalid username");
                    return;
                }
            }
            try
            {
                ImageConverter imgCon = new ImageConverter();
                var avatar = (byte[])imgCon.ConvertTo(avatarBox.Image, typeof(byte[]));
                var myAcc = new Account() { username = usernameBox.Text, password = passwordBox.Text, connected = true, typing = false, avatar = avatar };
                var task = accounts.InsertOneAsync(myAcc);
                var roomJoin = new Room_Join() { account = myAcc, database = database, client = client, accounts = accounts };
                roomJoin.Closed += (s, args) => this.Close();
                await task;
                this.Hide();
                roomJoin.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Your username has been taken", "Invalid username");
                return;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateAccount();
                e.SuppressKeyPress = true;
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateAccount();
                e.SuppressKeyPress = true;
            }
        }

        private void confirmBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateAccount();
                e.SuppressKeyPress = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };
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
                    img = ResizeImage(img, 107, 96);
                    avatarBox.Image = img;
                }
            }
        }
    }
}
