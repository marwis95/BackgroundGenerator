using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundGenerator
{
    public partial class Form1 : Form
    {
        public int x = 30, y = 95, fontSize = 25; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //pictureBox1.BackgroundImage = Image.FromFile("tlo.png");
            pictureBox1.Image = Image.FromFile("tlo.png");
            writeOnImage();

        }

        private void writeOnImage()
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(18,71,149));
            pictureBox1.Image = Image.FromFile("tlo.png");
           // var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var image = new Bitmap(this.pictureBox1.Image, this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(textBox1.Text, font, brush, new Point(x, y));
            this.pictureBox1.Image = image;
            label2.Text = x.ToString();
            label4.Text = y.ToString();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            writeOnImage();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            x = x + 1;
            writeOnImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = x - 1;
            writeOnImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = x + 10;
            writeOnImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = x - 10;
            writeOnImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("qwe.png", System.Drawing.Imaging.ImageFormat.Png); 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            y = y + 10;
            writeOnImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            y = y + 1;
            writeOnImage();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            y = y - 1;
            writeOnImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            y = y - 10;
            writeOnImage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fontSize = fontSize - 1;
            writeOnImage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fontSize = fontSize + 1;
            writeOnImage();
        }


    }
}
