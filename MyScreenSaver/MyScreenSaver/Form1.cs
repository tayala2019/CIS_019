using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class formScreenSaver : Form
    {
        public formScreenSaver()
        {
            InitializeComponent();
        }

        private void formScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            //press any key to close screen sceen saver
            Close();
        }
    }
}
