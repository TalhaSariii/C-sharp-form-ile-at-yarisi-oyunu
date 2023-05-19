using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders._10_At_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birsolauzaklık,ikisolauzaklık,ucsolauzaklık;

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            label6.Text = "";
           
            pictureBox1.Left = label7.Right;
            pictureBox2.Left = label8.Right;
            pictureBox3.Left = label9.Right;
            label13.Text = (" ");
            label14.Text = (" ");
            label15.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birsolauzaklık = pictureBox1.Left;
            ikisolauzaklık = pictureBox2.Left;
            ucsolauzaklık  = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birgenisligi = pictureBox1.Width;
            int ikigenisligi = pictureBox2.Width;
            int ucgenisligi  = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 20);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 20);



            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left < pictureBox1.Left + 5 || pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left < pictureBox2.Left + 5)
            {
                label14.Text = ("Üç Numaralı At");
            }


            if (pictureBox3.Left < pictureBox2.Left + 5 && pictureBox3.Left < pictureBox1.Left + 5)
            {
                label15.Text = ("Üç Numaralı At");
            }




            if (5 + pictureBox1.Left < pictureBox2.Left && pictureBox2.Left < pictureBox3.Left + 5 || pictureBox3.Left + 5 < pictureBox2.Left && pictureBox2.Left < pictureBox1.Left + 5)
            {
                label14.Text = ("İki Numaralı At");
            }

            if (5 + pictureBox1.Left > pictureBox2.Left && pictureBox2.Left < pictureBox3.Left + 5)
            {
                label15.Text = ("iki Numaralı At");
            }
            


            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left < pictureBox3.Left + 5 || pictureBox1.Left > pictureBox3.Left + 5 && pictureBox1.Left < pictureBox2.Left + 5)
            {
                label14.Text = ("Bir Numaralı At");
            }

            if (pictureBox1.Left < pictureBox2.Left + 5 && pictureBox1.Left < pictureBox3.Left + 5)
            {
                label15.Text = ("Bir Numaralı At");
            }

            if (pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text = ("1 Numaralı At Önde ");
                label13.Text = ("Bir Numaralı At");
            }
            if ( pictureBox1.Left + 5< pictureBox2.Left && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = ("2 Numaralı At Yarışı Önde Götürüyor");
                label13.Text = ("İki Numaralı At");
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = ("3 Numaralı At Önde ");
                label13.Text = ("Üç Numaralı At");
            }

            if (birgenisligi+pictureBox1.Left>=bitisuzaklıgı)
            {
                timer1.Enabled= false;
                label6.Text = ("1 Numaralı At Yarışı kazandı");
            }
            if (ikigenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = ("2 Numaralı At Yarışı kazandı");
            }
            if (ucgenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = ("3 Numaralı At Yarışı kazandı");
            }
        }
    }
    }

       
        
