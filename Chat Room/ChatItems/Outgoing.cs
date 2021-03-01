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
    public partial class Outgoing : UserControl
    {
        private Image image = Properties.Resources.reply;
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
        public Outgoing()
        {
            InitializeComponent();
        }

        private void AdjustHeight()
        {
            
            label1.Location = new Point(199, 12);
            label2.Height = Utils.GetTextHeight(label2) + 10;
            bunifuUserControl1.Height = label2.Top + bunifuUserControl1.Top + label2.Height;
            this.Height = bunifuUserControl1.Bottom + 10;
        }

        private void AdjustWidth()
        {
            label1.Location = new Point(249, 12);
            label2.Width = Math.Max(Utils.GetTextWidth(label2), Utils.GetTextWidth(label1)) + 10;
            bunifuUserControl1.Width = Math.Max(label2.Left + bunifuUserControl1.Top + label2.Width, label1.Left + bunifuUserControl1.Top + label1.Width) - 235;
            this.Width = bunifuUserControl1.Right + 8;
        }

        private void Incoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
            AdjustWidth();
        }

        private void Outgoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
            AdjustWidth();
        }
    }
}
