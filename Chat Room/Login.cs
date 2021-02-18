﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Login : Form
    {
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Account> accounts;
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient("mongodb+srv://<username>:<password>@cluster0.n2h9d.mongodb.net/chatroom?retryWrites=true&w=majority");
                database = client.GetDatabase("AppManagement");
                accounts = database.GetCollection<Account>("accounts");
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot connect to server", "Connection error");
                this.Close();
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
                else if (myAcc.password != passwordBox.Text)
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
    }
}