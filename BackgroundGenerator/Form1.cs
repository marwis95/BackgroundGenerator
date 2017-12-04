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
        public int x = 0, y = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImage = Image.FromFile("tlo.png");

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            x = x + 10;
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(textBox1.Text, font, Brushes.Black, new Point(x, y));
            this.pictureBox1.Image = image;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(textBox1.Text, font, Brushes.Black, new Point(x, y));
            this.pictureBox1.Image = image;

        }
    }
}
