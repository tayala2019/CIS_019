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
    }
}
