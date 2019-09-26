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
        Random rand = new Random();
        List<string> icons = new List<string>()
        {
            "N","N","P","P","L","L","V","V","G","G","X","X","I","I","J","J","A","A"
        };

        Label fistClicked, secondCLicked;

        public Form1()
        {
            InitializeComponent();
            AssignIconsTwoSquare();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Label_Clicked(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
            {
                return;
            }
            if (clickedLabel.ForeColor==Color.Black)
            {
                return;
            }
            if (fistClicked ==null)
            {
                fistClicked = clickedLabel;
                fistClicked.ForeColor = Color.Black;
                return;
            }
        }

        private void rW(object sender, EventArgs e)
        {

        }

        private void AssignIconsTwoSquare()
        {
            Label label;
            int randomNum;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;

                    randomNum = rand.Next(0, icons.Count);
                    label.Text = icons[randomNum];
                    icons.RemoveAt(randomNum);
                }
            }


        }

    }

}
