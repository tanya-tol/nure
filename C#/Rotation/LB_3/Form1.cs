using System.Text;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LB_3
{
    public partial class Form1 : Form
    {
        private Image img;
        private Image img2;
        public float degrees;

        public Form1()
        {
            InitializeComponent();
        }
        Bitmap Image1;
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width += 10;
            pictureBox1.Height += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width -= 10;
            pictureBox1.Height -= 10;
        }
        private void setPicBoxImage()
        {
            this.pictureBox1.Image = img;
            this.pictureBox2.Image = img2;
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawEllipse(new Pen(Brushes.Red, 3), new Rectangle(pictureBox1.Image.Width/2-50, pictureBox1.Image.Height/2-50, 100, 100));
        }
        
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog() ;
            string fileName = openFileDialog1.FileName;

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
			            if(stream != null)
			{                
                img = Image.FromStream(stream);
                img2 = Image.FromStream(stream);
                this.setPicBoxImage();
                stream.Close();
			}
        }
        private Bitmap rotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //rotate
            g.RotateTransform(angle);
            //move image back
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //draw passed in image onto graphics object
            g.DrawImage(b, new Point(0, 0));
            return returnBitmap;
        }

        private void butRotate_Click(object sender, EventArgs e)
        {
            this.degrees = (float)Convert.ToDouble(tbRotateAmount.Text);
            
                img = this.rotateImage((Bitmap)img, degrees);
                this.setPicBoxImage();
        }

        private void tbRotateAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
