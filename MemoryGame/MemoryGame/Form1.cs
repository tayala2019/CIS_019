using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"
        };

        Label fistClicked, secondCLicked;

        public Form1()
        {
            InitializeComponent();
            AssignIconsTwoSquare();
        }
        private void Label_Click(object sender, EventArgs e)
        {
            if (fistClicked != null && secondCLicked != null)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
            {
                return;
            }
            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }
            if (fistClicked == null)
            {
                fistClicked = clickedLabel;
                fistClicked.ForeColor = Color.Black;
                return;
            }

            secondCLicked = clickedLabel;
            secondCLicked.ForeColor = Color.Black;

            CheckForWinner();
            if (fistClicked.Text==secondCLicked.Text)
            {
                fistClicked = null;
                secondCLicked = null;
            }
            else
            timer1.Start();
        }
        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {

                label = tableLayoutPanel1.Controls[i] as Label;
            
            if (label != null && label.ForeColor == label.BackColor)
                return;

            }
            MessageBox.Show("You matched all the icons! Congratulations");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            fistClicked.ForeColor = fistClicked.BackColor;
            secondCLicked.ForeColor = secondCLicked.BackColor;

            fistClicked = null;
            secondCLicked = null;
            


        }

        private void AssignIconsTwoSquare()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                
                    continue;

                    randomNumber = random.Next(0, icons.Count);
                    label.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                
            }


        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void rW(object sender, EventArgs e)
        {

        }

       

    }

}
