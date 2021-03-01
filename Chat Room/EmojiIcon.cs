using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Chat_Room
{
    public class EmojiIcon:Button
    {
        public BunifuTextBox textBox { get; set; }
        public string icon;
        public EmojiIcon(string _icon)
        {
            this.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular);
            this.icon = _icon;
            this.Text = this.icon;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(30, 30);
            this.Click += new EventHandler(this.AddEmoji);
        }

        public void AddEmoji(object sender, EventArgs e)
        {
            this.textBox.Text += this.icon;
        }
    }
}
