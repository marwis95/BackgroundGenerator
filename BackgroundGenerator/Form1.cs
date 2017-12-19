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
        public int PictureX, PictureY, PictreWidth, PictureHeight;
        public string path = null;
        public string path_bg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            path = "default.png";
            path_bg = "tlo.png";
            PictureX = 420;
            PictureY = 210;
            Bitmap image_tmp = new Bitmap(Image.FromFile(path));
            PictreWidth = image_tmp.Width;
            PictureHeight = image_tmp.Height;

            pictureBox1.Image = Image.FromFile(path_bg);
            writeOnImage();

        }

        private void writeOnImage()
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(18,71,149));
            pictureBox1.Image = Image.FromFile(path_bg);
            var image = new Bitmap(this.pictureBox1.Image, this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Prime", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);

            if (path != null)
            {
                Bitmap image2 = new Bitmap(Image.FromFile(path));
                graphics.DrawImage(image2, new Rectangle(PictureX, PictureY, PictreWidth, PictureHeight));
            }

            if(radioButton1.Checked == true)
                graphics.DrawString(richTextBox1.Text, font, brush, new Point(x, y));

            if (radioButton2.Checked == true)
                graphics.DrawString(richTextBox1.Text, font, Brushes.White, new Point(x, y));

            if (radioButton3.Checked == true)
                graphics.DrawString(richTextBox1.Text, font, Brushes.Black, new Point(x, y));

            this.pictureBox1.Image = image;
            label2.Text = x.ToString();
            label4.Text = y.ToString();
            label7.Text = PictureX.ToString();
            label9.Text = PictureY.ToString();

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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png|*png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                if (path.Contains(".png"))
                {
                    pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    pictureBox1.Image.Save(path + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }

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

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Png|*png|Jpg|*.jpg|Bmp|*bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                PictureX = 350;
                PictureY = 210;
                Bitmap image_tmp = new Bitmap(Image.FromFile(path));
                PictreWidth = image_tmp.Width;
                PictureHeight = image_tmp.Height;
                writeOnImage();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PictureX = PictureX - 10;
            writeOnImage();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PictureX = PictureX - 1;
            writeOnImage();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PictureX = PictureX + 1;
            writeOnImage();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PictureX = PictureX + 10;
            writeOnImage();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PictureY = PictureY + 10;
            writeOnImage();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            PictureY = PictureY + 1;
            writeOnImage();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PictureY = PictureY - 1;
            writeOnImage();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            PictureY = PictureY - 10;
            writeOnImage();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            writeOnImage();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            writeOnImage();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            writeOnImage();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            writeOnImage();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PictreWidth = PictreWidth - 1;
            PictureHeight = PictureHeight - 1;
            writeOnImage();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PictreWidth = PictreWidth + 1;
            PictureHeight = PictureHeight + 1;
            writeOnImage();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = 578;
            pictureBox1.Height = 383;
            writeOnImage();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = 690;
            pictureBox1.Height = 496;
            writeOnImage();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_bg = new OpenFileDialog();
            open_bg.Filter = "Png|*png|Jpg|*.jpg|Bmp|*bmp";

            if (open_bg.ShowDialog() == DialogResult.OK)
            {
                path_bg = open_bg.FileName;
                MessageBox.Show(path_bg);
                pictureBox1.Image = Image.FromFile(path_bg);
                writeOnImage();
            }



        }

  


    }
}
