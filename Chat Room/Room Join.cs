﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Room_Join : Form
    {
        public IMongoCollection<Account> accounts { get; set; }
        public MongoClient client { get; set; }
        public Account account { get; set; }
        public IMongoDatabase database { get; set; }

        private IMongoCollection<ChatRoom> chatRooms;
        private IMongoDatabase joinRoomdb;
        public Room_Join()
        {
            InitializeComponent();
        }

        private void Room_Join_Reload()
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                string text = "";
                int c = 1;
                if (account.rooms != null)
                {
                    foreach (string id in account.rooms)
                    {
                        var roomdb = client.GetDatabase($"#{id}");
                        var unread = roomdb.GetCollection<Message>($"{account.username} receives").CountDocuments(s => true);
                        text += $"{c}. #{id}\n{unread} unread message(s)\n";
                        c++;
                    }
                    roomsBox.Text = text;
                }
            }
        }

        private void Room_Join_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Okaeri {account.username}-sama";
            avatarBox.Image = byteArrayToImage(account.avatar);
            var c = 1;
            foreach (string id in account.rooms)
            {
                var roomdb = client.GetDatabase($"#{id}");
                var unread = roomdb.GetCollection<Message>($"{account.username} receives").CountDocuments(s => true);
                roomsBox.Text += $"{c}. #{id}\n{unread} unread message(s)\n";
                c++;
            }
            timer1.Start();
            try
            {
                chatRooms = database.GetCollection<ChatRoom>("rooms");
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to server", "Connection error");
                this.Close();
            }
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

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private bool IdCheck()
        {
            string id = boxId.Text.Trim();
            var isNumeric = int.TryParse(id, out _);
            if (!isNumeric || id.Length != 6)
            {
                return false;
            }
            return true;
        }

        private bool PassCheck()
        {
            string password = boxPassword.Text;
            if (password.Contains(" ") || password.Length < 6)
            {
                return false;
            }
            return true;
        }

        private async void JoinRoom(string id, string pass)
        {
            var room = chatRooms.Find(s => s.Id == id).FirstOrDefault();
            if (room != null)
            {
                if (!room.state && room.password != Encrypt(Convert.ToBase64String(Encoding.UTF8.GetBytes(pass))))
                {
                    MessageBox.Show("Your room's password is incorrect, please re-type the room's password", "Incorrect room's password");
                    return;
                }
                else
                {
                    joinRoomdb = client.GetDatabase($"#{id}");
                    var roomAccounts = joinRoomdb.GetCollection<Account>("accounts");
                    var myAcc = roomAccounts.Find(s => s.username == account.username).FirstOrDefault();
                    if (myAcc != null)
                    {
                        if (myAcc.connected)
                        {
                            MessageBox.Show("You are already in this room.", "Warning");
                        }
                        else
                        {
                            var filter = Builders<Account>.Filter.Eq("_id", myAcc.username);
                            var update = Builders<Account>.Update.Set("connected", true);
                            roomAccounts.UpdateOne(filter, update);
                            var ChatRoom = new NewRoom() { username = myAcc.username, database = joinRoomdb, name = $"#{room.Id}: {room.name}", label = room.name, controlAccounts = accounts, Id = room.Id, controldb = database };
                            ChatRoom.Show();
                            this.FormClosing += new FormClosingEventHandler((object sender, FormClosingEventArgs e) => { ChatRoom.Close(); });
                        }
                    }
                    else
                    {
                        account.rooms.Add(id);
                        var temprooms = account.rooms;
                        var tempava = account.avatar;
                        var filterRooms = Builders<Account>.Filter.Eq("_id", account.username);
                        var updateRooms = Builders<Account>.Update.Set("rooms", account.rooms);
                        var task1 = accounts.UpdateOneAsync(filterRooms, updateRooms);
                        account.avatar = null;
                        account.rooms = null;
                        var task2 = roomAccounts.InsertOneAsync(account);
                        var contactAccs = roomAccounts.Find(s => s.username != account.username).ToList();
                        var myContacts = new HashSet<string>();
                        Parallel.ForEach(contactAccs, acc =>
                        {
                            acc.contacts.Add(account.username);
                            var filterAcc = Builders<Account>.Filter.Eq("_id", acc.username);
                            var updateAcc = Builders<Account>.Update.Set("contacts", acc.contacts);
                            roomAccounts.UpdateOneAsync(filterAcc, updateAcc);
                            myContacts.Add(acc.username);
                        });
                        var filter = Builders<Account>.Filter.Eq("_id", account.username);
                        var update = Builders<Account>.Update.Set("contacts", myContacts);
                        var task3 = roomAccounts.UpdateOneAsync(filter, update);
                        joinRoomdb.CreateCollection($"{account.username} receives");
                        var ChatRoom = new NewRoom() { username = account.username, database = joinRoomdb, name = $"#{room.Id}: {room.name}", label = room.name, controlAccounts = accounts, Id = room.Id, controldb = database };
                        await task1;
                        await task2;
                        await task3;
                        account.avatar = tempava;
                        account.rooms = temprooms;
                        ChatRoom.Show();
                        this.FormClosing += new FormClosingEventHandler((object sender, FormClosingEventArgs e) => { ChatRoom.Close(); });
                    }
                }
            }
            else
            {
                MessageBox.Show("Your room's ID does not exist, please re-type the room's ID", "Incorrect room's ID");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = boxId.Text.Trim();
            string pass = boxPassword.Text;
            if (!IdCheck())
            {
                MessageBox.Show("Your room's ID is invalid, please re-type the room's ID", "Invalid room's ID");
                return;
            }
            if (checkBox3.Checked && !PassCheck())
            {
                MessageBox.Show("You want to join a private room but your room's password is invalid, please re-type the room's password", "Invalid room's password");
                return;
            }
            JoinRoom(id, pass);
        }

        private string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "";
                string secretkey = "";
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

        private async void CreateRoom(string id, string pass, string name)
        {
            try
            {
                ChatRoom myRoom;
                if (checkBox2.Checked)
                {
                    myRoom = new ChatRoom() { Id = id, name = name, password = null, state = true };
                }
                else
                {
                    myRoom = new ChatRoom() { Id = id, name = name, password = Encrypt(Convert.ToBase64String(Encoding.UTF8.GetBytes(pass))) };
                }
                var task1 = chatRooms.InsertOneAsync(myRoom);
                account.rooms.Add(id);
                var filterRooms = Builders<Account>.Filter.Eq("_id", account.username);
                var updateRooms = Builders<Account>.Update.Set("rooms", account.rooms);
                var task2 = accounts.UpdateOneAsync(filterRooms, updateRooms);
                var newRoomdb = client.GetDatabase($"#{id}");
                newRoomdb.CreateCollection("accounts");
                newRoomdb.CreateCollection("messages");
                newRoomdb.CreateCollection($"{account.username} receives");
                var roomAccs = newRoomdb.GetCollection<Account>("accounts");
                var temprooms = account.rooms;
                var tempava = account.avatar;
                account.avatar = null;
                account.rooms = null;
                var task3 = roomAccs.InsertOneAsync(account);
                var ChatRoom = new NewRoom() { username = account.username, database = newRoomdb, name = $"#{myRoom.Id}: {myRoom.name}", label = myRoom.name, controlAccounts = accounts, Id = myRoom.Id, controldb = database };
                await task1;
                await task2;
                await task3;
                account.avatar = tempava;
                account.rooms = temprooms;
                ChatRoom.Show();
                this.FormClosing += new FormClosingEventHandler((object sender, FormClosingEventArgs e) => { ChatRoom.Close(); });
            }
            catch (Exception)
            {
                MessageBox.Show("The room's ID has been taken, please re-type your room's ID", "Invalid room's ID");
                return;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = boxName.Text.Trim();
            string id = boxId.Text.Trim();
            string pass = boxPassword.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Your room's name is invalid, please re-type the room's name", "Invalid room's name");
                return;
            }
            if (!IdCheck())
            {
                MessageBox.Show("Your room's ID is invalid, please re-type the room's ID", "Invalid room's ID");
                return;
            }
            if (checkBox3.Checked && !PassCheck())
            {
                MessageBox.Show("Your room's password is invalid, please re-type the room's password", "Invalid room's password");
                return;
            }
            CreateRoom(id, pass, name);
        }

        private void Room_Join_FormClosed(object sender, FormClosedEventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("_id", account.username);
            var updateConnection = Builders<Account>.Update.Set("connected", false);
            accounts.UpdateOneAsync(filter, updateConnection);
        }

        private void button3_Click(object sender, EventArgs e)
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
                    img = ResizeImage(img, 100, 100);
                    avatarBox.Image = img;
                    ImageConverter imgCon = new ImageConverter();
                    var avatar = (byte[])imgCon.ConvertTo(img, typeof(byte[]));
                    var filter = Builders<Account>.Filter.Eq("_id", account.username);
                    var updateAva = Builders<Account>.Update.Set("avatar", avatar);
                    accounts.UpdateOneAsync(filter, updateAva);
                } 
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var publicRooms = chatRooms.Find(s => s.state).ToList();
            var roomsShow = new InfoShow() { infoType = "rooms", publicRooms = publicRooms };
            roomsShow.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(Room_Join_Reload);
            t.IsBackground = true;
            t.Start();
        }

        private void LogOut()
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                LogOut();
            }
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.FromArgb(0, 140, 255);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.DimGray;
        }
    }
}
