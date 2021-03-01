using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room.ChatItems
{
    public partial class Incoming : UserControl
    {
        public string username
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                AdjustWidth();
            }
        }
        public string content
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
                AdjustHeight();
                AdjustWidth();
            }
        }
        public Incoming()
        {
            InitializeComponent();
        }

        private void AdjustHeight()
        {
            label1.Location = new Point(15, 12);
            label2.Height = Utils.GetTextHeight(label2) + 10;
            bunifuUserControl1.Height = label2.Top + bunifuUserControl1.Top + label2.Height;
            this.Height = bunifuUserControl1.Bottom + 10;
        }

        private void AdjustWidth()
        {
            label1.Location = new Point(15, 12);
            label2.Width = Math.Max(Utils.GetTextWidth(label2), Utils.GetTextWidth(label1)) + 10;
            bunifuUserControl1.Width = Math.Max(label2.Left + bunifuUserControl1.Top + label2.Width, label1.Left + bunifuUserControl1.Top + label1.Width);
            this.Width = bunifuUserControl1.Right + 10 + replyButton.Width;
        }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
            AdjustWidth();
        }

        private void Incoming_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
            AdjustWidth();
        }
    }
}
