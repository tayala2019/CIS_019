using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPaint
{
    public partial class Form1 : Form
    {
        //set bitmap variable with a screen size 1024 x 768
        Bitmap bmp = new Bitmap(1024,768);
        //pen color is any of the pallette butoons
        Pen P = new Pen(Color.Black,5);
        //set when the left mouse button is pressed/held wil activae a draw
        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Based on the button that the user presses of these choices will be activated
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Based on the button that the user presses of these choices will be activated
            if (drawing)
            {
                //passing the graphics variable the bitmap 
                Graphics g = Graphics.FromImage(bmp);
                //reference the Graphcis variable and pass the pen vaiable and set the X and y axis
                //e represents the ellipse
                g.DrawEllipse(P, e.X, e.Y, 3, 1);
                //referentce the picture box with the attached image method and passing in the bmp variable
                pictureBox1.Image = bmp;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            P.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            P.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            P.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            P.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            P.Color = Color.Lime;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            P.Color = Color.Black;
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            P.Color = Color.White;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reference the saveFileDialog and set it to a new instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpeg|Bitmap Image*.bmp|";
            saveFileDialog1.Title = "Save an immage file";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName !="")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
          
                switch (saveFileDialog1.FilterIndex)
                {
                //Check for two different file types
                case 1:
                    this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                  }
            }

        }
    }
}

