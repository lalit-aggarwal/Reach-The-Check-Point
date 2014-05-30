using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reach_The_Check_Point
{
    public partial class Form1 : Form
    {
        Point move = new Point();
        Point p_8 = new Point();
        Point p_7 = new Point();
        Point p_5 = new Point();
        Point p_4 = new Point();
        Point p_1 = new Point();
        Point p_2 = new Point();
        Point p_3 = new Point();

        int x_8, y_8, x_7, y_7, x_5, y_5, x_4, y_4, x_3, y_3, x_2, y_2, x_1, y_1;
        int xmov_8 = 8;
        int xmov_7 = 10;
        int xmov_5 = 12;
        int xmov_4 = 14;
        int xmov_3 = 16;
        int xmov_2 = 18;
        int xmov_1 = 20;
        int x_dest, y_dest;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x_dest = pictureBox6.Location.X;
            y_dest = pictureBox6.Location.Y;
            x_8 = pictureBox8.Location.X;
            y_8 = pictureBox8.Location.Y;
            x_7 = pictureBox7.Location.X;
            y_7 = pictureBox7.Location.Y;
            x_5 = pictureBox5.Location.X;
            y_5 = pictureBox5.Location.Y;
            x_4 = pictureBox4.Location.X;
            y_4 = pictureBox4.Location.Y;
            x_3 = pictureBox3.Location.X;
            y_3 = pictureBox3.Location.Y;
            x_2 = pictureBox2.Location.X;
            y_2 = pictureBox2.Location.Y;
            x_1 = pictureBox1.Location.X;
            y_1 = pictureBox1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x_8 += xmov_8;
            p_8.X = x_8;
            p_8.Y = y_8;
            pictureBox8.Location = p_8;
            
            x_7 -= xmov_7;
            p_7.X = x_7;
            p_7.Y = y_7;
            pictureBox7.Location = p_7;
     
            x_5 += xmov_5;
            p_5.X = x_5;
            p_5.Y = y_5;
            pictureBox5.Location = p_5;
            
            x_4 -= xmov_4;
            p_4.X = x_4;
            p_4.Y = y_4;
            pictureBox4.Location = p_4;

            x_3 += xmov_3;
            p_3.X = x_3;
            p_3.Y = y_3;
            pictureBox3.Location = p_3;
            
            x_2 -= xmov_2;
            p_2.X = x_2;
            p_2.Y = y_2;
            pictureBox2.Location = p_2;

            x_1 += xmov_1;
            p_1.X = x_1;
            p_1.Y = y_1;
            pictureBox1.Location = p_1;

            if (x_1 <= 0 || x_1 + 100 >= 285)
                xmov_1 *= -1;
            if (x_2 <= 0 || x_2 + 100 >= 285)
                xmov_2 *= -1;
            if (x_3 <= 0 || x_3 + 100 >= 285)
                xmov_3 *= -1;
            if (x_4 <= 0 || x_4 + 100 >= 285)
                xmov_4 *= -1;
            if (x_5 <= 0 || x_5 + 100 >= 285)
                xmov_5 *= -1;
            if (x_7 <= 0 || x_7 + 100 >= 285)
                xmov_7 *= -1;
            if (x_8 <= 0 || x_8 + 100 >= 285)
                xmov_8 *= -1;

            if (move.X >= p_8.X && move.X <= p_8.X + 100 && move.Y >= p_8.Y && move.Y <= p_8.Y+10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_7.X && move.X <= p_7.X + 100 && move.Y >= p_7.Y && move.Y <= p_7.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_5.X && move.X <= p_5.X + 100 && move.Y >= p_5.Y && move.Y <= p_5.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_4.X && move.X <= p_4.X + 100 && move.Y >= p_4.Y && move.Y <= p_4.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_3.X && move.X <= p_3.X + 100 && move.Y >= p_3.Y && move.Y <= p_3.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_2.X && move.X <= p_2.X + 100 && move.Y >= p_2.Y && move.Y <= p_2.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= p_1.X && move.X <= p_1.X + 100 && move.Y >= p_1.Y && move.Y <= p_1.Y + 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU LOOSE");
                Application.Exit();
            }
            if (move.X >= x_dest && move.X <= x_dest + 20 && move.Y >= y_dest + 5 && move.Y <= y_dest + 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOU WON");
                Application.Exit();
            }
        }
        int a = 2;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            move.X = pictureBox9.Location.X;
            move.Y = pictureBox9.Location.Y;
            if(e.KeyChar == 'w')
            {
                move.Y-=a;
            }
            if (e.KeyChar == 'a')
            {
                move.X-=a;
            }
            if (e.KeyChar == 's')
            {
                move.Y += a;
            }
            if (e.KeyChar == 'd')
            {
                move.X+=a;
            }
            pictureBox9.Location = move;
        }
    }
}
