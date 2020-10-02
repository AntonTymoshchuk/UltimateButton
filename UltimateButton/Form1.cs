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

namespace UltimateButton
{
    public partial class Form1 : Form
    {
        private NoFocusCuesButton button;
        private NoFocusCuesButton button1;

        public Form1()
        {
            InitializeComponent();
            InitializeButton();
        }

        public void InitializeButton()
        {
            button = new NoFocusCuesButton();
            button.TabIndex = 0;
            button.TabStop = true;
            button.Location = new Point(50, 100);
            button.Size = new Size(200, 60);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.FromArgb(100, 100, 100);
            button.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Calibri", 18);
            button.ForeColor = Color.White;
            button.Text = "Button";
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.GotFocus += Button_GotFocus;
            button.MouseEnter += Button_MouseEnter;
            button.MouseDown += Button_MouseDown;
            button.MouseUp += Button_MouseUp;
            button.MouseLeave += Button_MouseLeave;
            button.LostFocus += Button_LostFocus;

            button1 = new NoFocusCuesButton();
            button1.TabIndex = 1;
            button1.TabStop = true;
            button1.Location = new Point(50, button.Bottom + 20);
            button1.Size = new Size(200, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.FromArgb(100, 100, 100);
            button1.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 120, 120);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Calibri", 18);
            button1.ForeColor = Color.White;
            button1.Text = "Button";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.GotFocus += Button_GotFocus;
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseDown += Button_MouseDown;
            button1.MouseUp += Button_MouseUp;
            button1.MouseLeave += Button_MouseLeave;
            button1.LostFocus += Button_LostFocus;

            Controls.Add(button);
            Controls.Add(button1);
        }

        private void Button_GotFocus(object sender, EventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.BackColor.R;
            int G = btn.BackColor.G;
            int B = btn.BackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.BackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.BorderColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.BackColor.R;
            int G = btn.BackColor.G;
            int B = btn.BackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.BackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.BorderColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.FlatAppearance.MouseOverBackColor.R;
            int G = btn.FlatAppearance.MouseOverBackColor.G;
            int B = btn.FlatAppearance.MouseOverBackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.FlatAppearance.BorderColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R + i * 2, G + i * 2, B + i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.FlatAppearance.MouseDownBackColor.R;
            int G = btn.FlatAppearance.MouseDownBackColor.G;
            int B = btn.FlatAppearance.MouseDownBackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.FlatAppearance.BorderColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.FlatAppearance.MouseOverBackColor.R;
            int G = btn.FlatAppearance.MouseOverBackColor.G;
            int B = btn.FlatAppearance.MouseOverBackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.BackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.BorderColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }
        }

        private void Button_LostFocus(object sender, EventArgs e)
        {
            NoFocusCuesButton btn = sender as NoFocusCuesButton;

            int R = btn.FlatAppearance.MouseOverBackColor.R;
            int G = btn.FlatAppearance.MouseOverBackColor.G;
            int B = btn.FlatAppearance.MouseOverBackColor.B;

            for (int i = 0; i < 10; i++)
            {
                btn.BackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.BorderColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(R - i * 2, G - i * 2, B - i * 2);
                btn.Refresh();
                Thread.Sleep(10);
            }
        }
    }
}
