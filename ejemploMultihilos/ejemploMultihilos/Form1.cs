using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ejemploMultihilos
{
    public partial class Form1 : Form
    {
        Thread p1;
        Thread p2;

        byte r, g;
        bool b1, b2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 0; g = 255; b1 = false; b2 = true;

            p1 = new Thread(new ThreadStart (Hilo1));
            p2 = new Thread(new ThreadStart (Hilo2));

            p1.Start();
            p2.Start();
        }
        public void Hilo1()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (r >= 0 && r <= 255 && b1 == false)
                {
                    r++;
                    if (r == 255)
                        b1 = true;
                }
                if (r >= 0 && r <= 255 && b1 == true)
                {
                    r--;
                    if (r == 0)
                        b1 = false;
                }
                pictureBox1.BackColor = Color.FromArgb(r, 80, 100);

            }
        }

        public void Hilo2()
        {
            while (true)
            {
                Thread.Sleep(10);

                if (g >= 0 && g <= 255 && b2 == false)
                {
                    g++;
                    if (g == 255)
                        b2 = true;
                }
                if (g >= 0 && g <= 255 && b2 == true)
                {
                    g--;
                    if (g == 0)
                        b2 = false;
                }
                pictureBox2.BackColor = Color.FromArgb(100, g, 80);
            }

        }

        private void formClos(object sender, FormClosedEventArgs e)
        {
            p1.Abort();
            p2.Abort();
        }

    }
}
