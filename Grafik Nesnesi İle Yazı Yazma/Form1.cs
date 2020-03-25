using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafik_Nesnesi_İle_Yazı_Yazma
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int t = 0;

        #endregion

        #region Tanımlamalar

        Random r = new Random();

        #endregion

        #region Metodlar

        public void yaz()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawString(textBox1.Text, new Font(FontFamily.Families[r.Next(100)], 30, FontStyle.Bold), new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))), r.Next(pictureBox1.Width), r.Next(pictureBox1.Height));
        
        }

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t % 2 == 0)
            {
                timer1.Enabled = true;
                yaz();
                button1.Text = "Durdur";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Yazdır";

            }
            t++;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yaz();
        }
    }
}
