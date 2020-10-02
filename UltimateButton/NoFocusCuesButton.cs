using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateButton
{
    public class NoFocusCuesButton:Button
    {
        protected override bool ShowFocusCues
        {
            get { return false; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(FlatAppearance.BorderColor, 1);
            Rectangle rectangle = new Rectangle(0, 0, Size.Width - 1, Size.Height - 1);
            e.Graphics.DrawRectangle(pen, rectangle);
        }
    }
}
