using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Room
{
    public class Utils
    {
        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }

        public static int GetTextWidth(Label lbl)
        {
            if (lbl.Image != null)
            {
                return (int)Math.Ceiling((decimal)lbl.Image.Width);
            }
            else
            {
                using (Graphics g = lbl.CreateGraphics())
                {
                    SizeF size = g.MeasureString(lbl.Text, lbl.Font, 495);
                    return (int)Math.Ceiling(size.Width);
                }
            }
        }
    }
}
