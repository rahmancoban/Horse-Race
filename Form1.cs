using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int horse1x, horse2x, horse3x;
        Random rast = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            horse1x = pictureBox1.Left;
            horse2x = pictureBox2.Left;
            horse3x = pictureBox3.Left;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();




            int horse1w = pictureBox1.Width;
            int horse2w = pictureBox2.Width;
            int horse3w = pictureBox3.Width;


            int finish = label5.Left;

            pictureBox1.Left = pictureBox1.Left+ rast.Next(4, 16);
            pictureBox2.Left = pictureBox2.Left+ rast.Next(4, 16);
            pictureBox3.Left = pictureBox3.Left + rast.Next(4, 16);

            if (pictureBox1.Left > pictureBox2.Left + 4 && pictureBox1.Left > pictureBox3.Left + 4)
            {
                label6.Text = "1 Nolu At Önde";
            }

            if (pictureBox2.Left > pictureBox1.Left + 4 && pictureBox2.Left > pictureBox3.Left + 4)
            {
                label6.Text = "2 Nolu At Önde";
            }

            if (pictureBox3.Left > pictureBox1.Left + 4 && pictureBox3.Left > pictureBox2.Left + 4)
            {
                label6.Text = "3 Nolu At Önde";
            }



            if (horse1w + pictureBox1.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text="1 Nolu At Kazandı";
            }

            if (horse2w + pictureBox2.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text="2 Numaralı At Kazandı";
            }

            if (horse3w + pictureBox3.Left >= finish)
            {
                timer1.Enabled = false;
                label6.Text="3 Numaralı At Kazandı";
            }



        }



    }
}
