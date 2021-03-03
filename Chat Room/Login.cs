using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Login : Form
    {
        public MongoClient client;
        public IMongoDatabase database;
        public IMongoCollection<Account> accounts;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient(Properties.Settings.Default.mongolink);
                database = client.GetDatabase("AppManagement");
                accounts = database.GetCollection<Account>("accounts");
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot connect to server", "Connection error");
                this.Close();
            }
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



        private async void LoginAccount()
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please fill in the missing username or password", "Missing information");
            }
            else if (passwordBox.Text.Contains(' ') || passwordBox.Text.Length < 6)
            {
                MessageBox.Show("Your password is invalid, please re-type your password", "Invalid password");
                return;
            }
            else if (usernameBox.Text.Contains(' '))
            {
                MessageBox.Show("Your username is invalid, please re-type your username", "Invalid username");
                return;
            }
            else
            {
                var myAcc = accounts.Find(s => s.username == usernameBox.Text).FirstOrDefault();
                if (myAcc == null)
                {
                    MessageBox.Show("Your username does not exist", "Incorrect username");
                }
                else if (myAcc.password != Encrypt(Convert.ToBase64String(Encoding.UTF8.GetBytes(passwordBox.Text))))
                {
                    MessageBox.Show("Your password is incorrect", "Incorrect password");
                }
                else
                {
                    if (myAcc.connected)
                    {
                        MessageBox.Show("Your account is currently online, you cannot log into a currently online account", "Currently online account");
                    }
                    else
                    {
                        var filter = Builders<Account>.Filter.Eq("_id", myAcc.username);
                        var updateConnection = Builders<Account>.Update.Set("connected", true);
                        var task = accounts.UpdateOneAsync(filter, updateConnection);
                        myAcc.connected = true;
                        var roomJoin = new Room_Join() { account = myAcc, database = database, client = client, accounts = accounts };
                        roomJoin.Closed += (s, args) => this.Reload();
                        await task;
                        this.Hide();
                        roomJoin.Show();
                    }
                }
            }
        }

        private void Reload()
        {
            this.Show();
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            LoginAccount();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var signup = new Sign_Up() { accounts = accounts , database = database, client = client};
            signup.Closed += (s, args) => this.Reload();
            signup.Show();
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAccount();
                e.SuppressKeyPress = true;
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAccount();
                e.SuppressKeyPress = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myAcc = accounts.Find(s => s.username == usernameBox.Text).FirstOrDefault();
            if (myAcc is null)
            {
                MessageBox.Show("Your username does not exist", "Incorrect username");
            }
            else
            {
                var validation = new Validation() { signin = this, account = myAcc };
                validation.FormClosed += (s, args) => this.Reload();
                this.Hide();
                validation.Show();
            }
        }
    }
}
