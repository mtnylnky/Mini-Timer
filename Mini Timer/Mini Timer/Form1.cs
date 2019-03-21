using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mini_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Interval = 1000;
        }

        /* Formu Tasima panel uzerinde */
        int move;
        int Mouse_X;
        int Mouse_Y;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label5.Text = "00";
            label4.Text = "00";
            label3.Text = "00";
            timer1.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label5.Text) < 9)
            {
                label5.Text = "0" + (int.Parse(label5.Text) + 1).ToString();
            }
            else
            {
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
            }
            if (int.Parse(label5.Text) == 60)
            {
                label5.Text = "00";
                if (int.Parse(label4.Text) < 9)
                {
                    label4.Text = "0" + (int.Parse(label4.Text) + 1).ToString();
                }
                else
                {
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                }
            }
            if (int.Parse(label4.Text) == 60)
            {
                label4.Text = "00";
                if (int.Parse(label3.Text) < 9)
                {
                    label3.Text = "0" + (int.Parse(label3.Text) + 1).ToString();
                }
                else
                {
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label11.Text) < 9)
            {
                label11.Text = "0" + (int.Parse(label11.Text) + 1).ToString();
            }
            else
            {
                label11.Text = (int.Parse(label11.Text) + 1).ToString();
            }
            if (int.Parse(label11.Text) == 60)
            {
                label11.Text = "00";
                if (int.Parse(label10.Text) < 9)
                {
                    label10.Text = "0" + (int.Parse(label10.Text) + 1).ToString();
                }
                else
                {
                    label10.Text = (int.Parse(label10.Text) + 1).ToString();
                }
            }
            if (int.Parse(label10.Text) == 60)
            {
                label10.Text = "00";
                if (int.Parse(label9.Text) < 9)
                {
                    label9.Text = "0" + (int.Parse(label9.Text) + 1).ToString();
                }
                else
                {
                    label9.Text = (int.Parse(label9.Text) + 1).ToString();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
