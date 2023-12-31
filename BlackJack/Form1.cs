using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private bool surukleniyor = false;
        private int surukleBaslangicX;
        private int surukleBaslangicY;
        public Form1()
        {
            InitializeComponent();
        }



        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                this.Left += e.X - surukleBaslangicX;
                this.Top += e.Y - surukleBaslangicY;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                surukleniyor = true;
                surukleBaslangicX = e.X;
                surukleBaslangicY = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Random rastegele = new Random();
        int sayaç = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            sayaç++;
            if (sayaç == 1)
            {
                int a1, a2, toplam;
                a1 = rastegele.Next(1, 11);
                a2 = rastegele.Next(1, 11);
                toplam = a1 + a2;
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayaç == 2)
            {
                int a3, toplam;
                a3 = rastegele.Next(1, 11);
                label3.Text = a3.ToString();


                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayaç == 3)
            {
                int a4, toplam;
                a4 = rastegele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }
            if(label1.Text=="1")
            {
                pictureBox1.Image= BlackJack.Properties.Resources.AS;
            }
            if(label1.Text=="2")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._2;
            }
            if(label1.Text=="3")
            {
                pictureBox1.Image=BlackJack.Properties.Resources._3;
            }
            if(label1.Text=="4")
            {
                pictureBox1.Image=BlackJack.Properties.Resources._4;

            }
            if(label1.Text=="5")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._5;
            }
            if (label1.Text == "6")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._6;

            }
            if (label1.Text == "7")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._7;
            }
            if (label1.Text == "8")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._8;

            }
            if (label1.Text == "9")
            {
                pictureBox1.Image = BlackJack.Properties.Resources._9;
            }
            if (label1.Text == "10")
            {
                pictureBox1.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label2.Text == "1")
            {
                pictureBox2.Image = BlackJack.Properties.Resources.AS;
            }
            if (label2.Text == "2")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._2;
            }
            if (label2.Text == "3")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._3;
            }
            if (label2.Text == "4")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._4;

            }
            if (label2.Text == "5")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._5;
            }
            if (label2.Text == "6")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._6;

            }
            if (label2.Text == "7")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._7;
            }
            if (label2.Text == "8")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._8;

            }
            if (label2.Text == "9")
            {
                pictureBox2.Image = BlackJack.Properties.Resources._9;
            }
            if (label2.Text == "10")
            {
                pictureBox2.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label3.Text == "1")
            {
                pictureBox3.Image = BlackJack.Properties.Resources.AS;
            }
            if (label3.Text == "2")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._2;
            }
            if (label3.Text == "3")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._3;
            }
            if (label3.Text == "4")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._4;

            }
            if (label3.Text == "5")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._5;
            }
            if (label3.Text == "6")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._6;

            }
            if (label3.Text == "7")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._7;
            }
            if (label3.Text == "8")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._8;

            }
            if (label3.Text == "9")
            {
                pictureBox3.Image = BlackJack.Properties.Resources._9;
            }
            if (label3.Text == "10")
            {
                pictureBox3.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label4.Text == "1")
            {
                pictureBox4.Image = BlackJack.Properties.Resources.AS;
            }
            if (label4.Text == "2")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._2;
            }
            if (label4.Text == "3")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._3;
            }
            if (label4.Text == "4")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._4;

            }
            if (label4.Text == "5")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._5;
            }
            if (label4.Text == "6")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._6;

            }
            if (label4.Text == "7")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._7;
            }
            if (label4.Text == "8")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._8;

            }
            if (label4.Text == "9")
            {
                pictureBox4.Image = BlackJack.Properties.Resources._9;
            }
            if (label4.Text == "10")
            {
                pictureBox4.Image = BlackJack.Properties.Resources.JOK;
            }
        }
        int sayac2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 1)
            {
                int b1, b2, toplam;
                b1 = rastegele.Next(1, 11);
                b2 = rastegele.Next(1, 11);
                toplam = b1 + b2;
                label5.Text = b1.ToString();
                label6.Text = b2.ToString();
                label11.Text = toplam.ToString();
            }
            if (sayac2 == 2)
            {
                int b3, toplam;
                b3 = rastegele.Next(1, 11);
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + b3;
                label7.Text = b3.ToString();
                label11.Text = toplam.ToString();
            }
            if (sayac2 == 3)
            {
                int b4, toplam;
                b4 = rastegele.Next(1, 11);
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label7.Text) + b4;
                label8.Text = b4.ToString();
                label11.Text = toplam.ToString();
            }
            if (label5.Text == "1")
            {
                pictureBox8.Image = BlackJack.Properties.Resources.AS;
            }
            if (label5.Text == "2")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._2;
            }
            if (label5.Text == "3")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._3;
            }
            if (label5.Text == "4")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._4;

            }
            if (label5.Text == "5")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._5;
            }
            if (label5.Text == "6")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._6;

            }
            if (label5.Text == "7")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._7;
            }
            if (label5.Text == "8")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._8;

            }
            if (label5.Text == "9")
            {
                pictureBox8.Image = BlackJack.Properties.Resources._9;
            }
            if (label5.Text == "10")
            {
                pictureBox8.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label6.Text == "1")
            {
                pictureBox7.Image = BlackJack.Properties.Resources.AS;
            }
            if (label6.Text == "2")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._2;
            }
            if (label6.Text == "3")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._3;
            }
            if (label6.Text == "4")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._4;

            }
            if (label6.Text == "5")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._5;
            }
            if (label6.Text == "6")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._6;

            }
            if (label6.Text == "7")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._7;
            }
            if (label6.Text == "8")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._8;

            }
            if (label6.Text == "9")
            {
                pictureBox7.Image = BlackJack.Properties.Resources._9;
            }
            if (label6.Text == "10")
            {
                pictureBox7.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label7.Text == "1")
            {
                pictureBox6.Image = BlackJack.Properties.Resources.AS;
            }
            if (label7.Text == "2")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._2;
            }
            if (label7.Text == "3")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._3;
            }
            if (label7.Text == "4")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._4;

            }
            if (label7.Text == "5")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._5;
            }
            if (label7.Text == "6")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._6;

            }
            if (label7.Text == "7")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._7;
            }
            if (label7.Text == "8")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._8;

            }
            if (label7.Text == "9")
            {
                pictureBox6.Image = BlackJack.Properties.Resources._9;
            }
            if (label7.Text == "10")
            {
                pictureBox6.Image = BlackJack.Properties.Resources.JOK;
            }
            if (label8.Text == "1")
            {
                pictureBox5.Image = BlackJack.Properties.Resources.AS;
            }
            if (label8.Text == "2")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._2;
            }
            if (label8.Text == "3")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._3;
            }
            if (label8.Text == "4")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._4;

            }
            if (label8.Text == "5")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._5;
            }
            if (label8.Text == "6")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._6;

            }
            if (label8.Text == "7")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._7;
            }
            if (label8.Text == "8")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._8;

            }
            if (label8.Text == "9")
            {
                pictureBox5.Image = BlackJack.Properties.Resources._9;
            }
            if (label8.Text == "10")
            {
                pictureBox5.Image = BlackJack.Properties.Resources.JOK;
            }

            if (sayac2 == 3 && sayaç == 3)
            {
                int o1, o2;
                o1 = Convert.ToInt32(label10.Text);
                o2 = Convert.ToInt32(label11.Text);

                if (o1 > 21)
                {
                    MessageBox.Show("Oyuncu 2 kazandı!");
                }
                if (o2 > 21)

                {
                    MessageBox.Show("Oyuncu 1 kazandı");
                }
                if (o1 == o2)
                {
                    MessageBox.Show("Berabere kimse kazanamadı!!");
                }
                button4.Visible = true;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = BlackJack.Properties.Resources._0;
            pictureBox2.Image = BlackJack.Properties.Resources._0;
            pictureBox3.Image = BlackJack.Properties.Resources._0;
            pictureBox4.Image = BlackJack.Properties.Resources._0;
            pictureBox5.Image = BlackJack.Properties.Resources._0;
            pictureBox6.Image = BlackJack.Properties.Resources._0;
            pictureBox7.Image = BlackJack.Properties.Resources._0;
            pictureBox8.Image = BlackJack.Properties.Resources._0;
            
            label1.Text = "";
            label2.Text= "";
            label3.Text= "";
            label4.Text= "";
            label5.Text= "";
            label6.Text= "";
            label7.Text= "";
            label8.Text= "";
            label10.Text= "0";
            label11.Text= "0";
            sayac2 = 0;
            sayaç = 0;
            button4.Visible= false;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
