using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLime
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CBO_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(CBO.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(CBO.Text);
        }
    }
}
