using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Chat_Room
{
    public partial class Validation : Form
    {
        public Login signin { get; set; } = null;
        public Sign_Up signup { get; set; } = null;
        private bool success = false;
        public Account account { get; set; }
        private string email;
        private string name;
        private int code;
        private bool validcode = false;
        public Validation()
        {
            InitializeComponent();
        }

        private void VerificationSend()
        {
            code = new Random().Next(100000, 999999);
            MailDefinition md = new MailDefinition();
            md.IsBodyHtml = true;
            md.Subject = "[Bob Lee Chatroom] Please verify your account";
            md.From = Properties.Settings.Default.emailaddress;
            ListDictionary replacements = new ListDictionary();
            replacements.Add("{name}", name);
            replacements.Add("{code}", code.ToString());
            string body = "<div>Hello {name}!</div><br><div>Welcome to Bob Lee's Chatroom. Your verification code is {code}. This code will expire in 2 minutes.</div>";
            var login = new NetworkCredential() { UserName = Properties.Settings.Default.emailaddress, Password = Properties.Settings.Default.emailpassword };
            var mailClient = new SmtpClient() { Host = "smtp.gmail.com", Port = 587, EnableSsl = true, DeliveryMethod = SmtpDeliveryMethod.Network, UseDefaultCredentials = false, Credentials = login };
            MailAddress FromEmail = new MailAddress(Properties.Settings.Default.emailaddress, "Bob Lee's Chatroom");
            MailAddress ToEmail = new MailAddress(email, name);
            string RegisterMessagePlain = $"Hey {name}!\n\nWelcome to Bob Lee's Chatroom. Your verification code is {code}. This code will expire in 2 minutes.";
            MailMessage Message = md.CreateMailMessage(email, replacements, body, new System.Web.UI.Control());
            Message.Priority = MailPriority.High;
            Message.From = FromEmail;
            Message.BodyEncoding = Encoding.UTF8;
            Message.SubjectEncoding = Encoding.Default;
            Message.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(RegisterMessagePlain, new ContentType("text/plain")));
            Message.To.Add(ToEmail);
            try
            {
                mailClient.Send(Message);
                validcode = true;
                timer1.Start();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            validcode = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            VerificationSend();
            MessageBox.Show("Verification code has been sent, please check your email.", "Code successfully resent");
        }

        private void LogIn()
        {
            var roomJoin = new Room_Join() { account = account, database = signin.database, client = signin.client, accounts = signin.accounts };
            roomJoin.Closed += (s, args) => this.Close();
            timer1.Stop();
            this.Hide();
            roomJoin.Show();
        }

        private async void CreateAccount()
        {
            var mail = new Email() { email = email };
            account.password = Convert.ToBase64String(Encoding.UTF8.GetBytes(account.password));
            account.password = Encrypt(account.password);
            var task = signup.accounts.InsertOneAsync(account);
            var task1 = signup.emails.InsertOneAsync(mail);
            var roomJoin = new Room_Join() { account = account, database = signup.database, client = signup.client, accounts = signup.accounts };
            roomJoin.Closed += (s, args) => this.Close();
            await task;
            await task1;
            success = true;
            timer1.Stop();
            this.Hide();
            roomJoin.Show();
        }

        private string Base64StringDecode(string encodedString)
        {
            var bytes = Convert.FromBase64String(encodedString);

            var decodedString = Encoding.UTF8.GetString(bytes);

            return decodedString;
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

        private string Decrypt(string textToDecrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "";
                string privatekey = "";
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == code.ToString())
            {
                if (validcode)
                {
                    if (signup is null)
                    {
                        MessageBox.Show($"Your password is {Base64StringDecode(Decrypt(account.password))}", "Successful verification");
                        LogIn();
                    }
                    else
                    {
                        CreateAccount();
                    }
                }
                else
                {
                    var dialogResult = MessageBox.Show("Your verification code has expired. Do you want another code?", "verification expired", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        timer1.Stop();
                        VerificationSend();
                        MessageBox.Show("Verification code has been sent, please check your email.", "Code successfully resent");
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Your verification code is incorrect", "Incorrect verification code");
            }
        }

        private void ValidationEmail_Load(object sender, EventArgs e)
        {
            email = account.email;
            name = account.username;
            VerificationSend();
        }

        private void ValidationEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (success && signup != null)
            {
                signup.Close();
            }
            else if (signup != null)
            {
                signup.Show();
            }
        }
    }
}
