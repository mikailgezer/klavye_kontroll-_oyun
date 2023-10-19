using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int sure;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 145);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x < 1000)
            {
                x = x + 5;
            }
            else if (e.KeyCode == Keys.Left && 0 < x)
            {
                x = x - 5;
            }
            else if (e.KeyCode == Keys.Up && y < 1000)
            {
                y = y - 5;
            }
            else if (e.KeyCode == Keys.Down && y < 500)
            {
                y = y + 5;
            }

            pictureBox1.Location = new Point(x, y);


            if (pictureBox1.Location.X >= 368 && pictureBox1.Location.Y <= 150)
            {
                if (sayac == 0)
                {
                    label5.Text = "Türkiye kaç çoğrafi bölgeye ayrılır?";
                    label6.Text = "7";
                    label7.Text = "21";
                    label8.Text = "63";
                    label9.Text = "81";
                    label11.Text = "7";
                    label13.Text = "A:";
                    label14.Text = "B:";
                    label15.Text = "C:";
                    label16.Text = "D:";
                }
            }
            if (pictureBox1.Location.X <= 386 && 276 <= pictureBox1.Location.Y && pictureBox1.Location.Y <= 288)
            {
                if (sayac == 1)
                {
                    label5.Text = "Almanya'nın başkenti neresidir?";
                    label6.Text = "Köln";
                    label7.Text = "Münih";
                    label8.Text = "Berlin";
                    label9.Text = "Frankurt";
                    label11.Text = "Berlin";
                    label13.Text = "A:";
                    label14.Text = "B:";
                    label15.Text = "C:";
                    label16.Text = "D:";
                }
            }

            if (pictureBox1.Location.X >= 786 && 412 <= pictureBox1.Location.Y && pictureBox1.Location.Y <= 422)
            {
                if (sayac == 2)
                {
                    label5.Text = "Eyfel Kulesi hangi şehirdedir?";
                    label6.Text = "Marsilya";
                    label7.Text = "Lyon";
                    label8.Text = "Şanzelize";
                    label9.Text = "Paris";
                    label11.Text = "Paris";
                    label13.Text = "A:";
                    label14.Text = "B:";
                    label15.Text = "C:";
                    label16.Text = "D:";
                }
            }

            if ( pictureBox1.Location.Y <= 137 || pictureBox1.Location.Y > 420)
            {
                pictureBox2.Location = new Point(468, 144);
                pictureBox3.Location = new Point(286, 283);
                pictureBox4.Location = new Point(882, 417);
                pictureBox1.Location = new Point(0, 145);
                sayac = 0;
                sure = 0;
                timer1.Stop();
            }
            if (pictureBox1.Location.Y >= 151 && pictureBox1.Location.Y <= 277 && pictureBox1.Location.X <= 895)
            {
                pictureBox2.Location = new Point(468, 144);
                pictureBox3.Location = new Point(286, 283);
                pictureBox4.Location = new Point(882, 417);
                pictureBox1.Location = new Point(0, 145);
                sayac = 0;
                sure = 0;
                timer1.Stop();
            }
            if (pictureBox1.Location.Y >= 286 && pictureBox1.Location.Y <= 414 && pictureBox1.Location.X > 19)
            {
                pictureBox2.Location = new Point(468, 144);
                pictureBox3.Location = new Point(286, 283);
                pictureBox4.Location = new Point(882, 417);
                pictureBox1.Location = new Point(0, 145);
                sayac = 0;
                sure = 0;
                timer1.Stop();
            }

            if (e.KeyCode == Keys.A)
            {
                label12.Text = label6.Text;
                if (label11.Text == label12.Text)
                {
                    sayac = sayac + 1;
                    label10.Text = sayac.ToString();

                }
                else
                {
                    pictureBox2.Location = new Point(468, 144);
                    pictureBox3.Location = new Point(286, 283);
                    pictureBox4.Location = new Point(882, 417);
                    pictureBox1.Location = new Point(0, 145);
                    sayac = 0;
                    sure = 0;
                    timer1.Stop();
                }
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label11.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";

            }
            if (e.KeyCode == Keys.B)
            {
                label12.Text = label7.Text;
                if (label11.Text == label12.Text)
                {
                    sayac = sayac + 1;
                    label10.Text = sayac.ToString();
                }
                else
                {
                    pictureBox2.Location = new Point(468, 144);
                    pictureBox3.Location = new Point(286, 283);
                    pictureBox4.Location = new Point(882, 417);
                    pictureBox1.Location = new Point(0, 145);
                    sayac = 0;
                    sure = 0;
                    timer1.Stop();
                }
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label11.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
            }
            if (e.KeyCode == Keys.C)
            {
                label12.Text = label8.Text;
                if (label11.Text == label12.Text)
                {
                    sayac = sayac + 1;
                    label10.Text = sayac.ToString();
                }
                else
                {
                    pictureBox2.Location = new Point(468, 144);
                    pictureBox3.Location = new Point(286, 283);
                    pictureBox4.Location = new Point(882, 417);
                    pictureBox1.Location = new Point(0, 145);
                    sayac = 0;
                    sure = 0;
                    timer1.Stop();
                }
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label11.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
            }
            if (e.KeyCode == Keys.D)
            {
                label12.Text = label9.Text;
                if (label11.Text == label12.Text)
                {
                    sayac = sayac + 1;
                    label10.Text = sayac.ToString();
                }
                else
                {
                    pictureBox2.Location = new Point(468, 144);
                    pictureBox3.Location = new Point(286, 283);
                    pictureBox4.Location = new Point(882, 417);
                    pictureBox1.Location = new Point(0, 145);
                    sayac = 0;
                    sure = 0;
                    timer1.Stop();
                }
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label11.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure + 1;
            label18.Text = sure.ToString();
            label10.Text = sayac.ToString();

            if (sayac == 1)
            {
                pictureBox2.Location = new Point(286, 5);
            }

            if (sayac == 2)
            {
                pictureBox3.Location = new Point(392, 5);
            }

            if (sayac == 3)
            {
                pictureBox4.Location = new Point(498, 5);
                timer1.Stop();
                MessageBox.Show("Tebrikler Oyunu " + sure.ToString() + " saniyede tamamladınız. :)");
            }
        }
    }
}
