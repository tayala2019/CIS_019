using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void setBkgrdColor_Click(object sender, EventArgs e)
        {
            //Show the color dialogbox, if the user clicks OK, change the 
            //PictureBox control's background to the color the user chooses.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor= colorDialog1.Color;
            }

        }

        private void clearPicture_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox1.Image = null;
        }

        private void showPicture_Click(object sender, EventArgs e)
        {
            //Show the Open File Dialog. If the user clicks OK
            //load the picture that the user choose.
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /** If the user selects the stretch check box
             * change the pictureBox's
             * SizeMode property to "stretch". If the usser clears
             * the checkbox, change it to "Normal".
             * */
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
