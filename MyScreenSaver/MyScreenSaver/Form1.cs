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
        List<Image> BGImages = new List<Image>();
        List<PeacePic> PeacePics = new List<PeacePic>();
        Random rand = new Random();

        class PeacePic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }
        public formScreenSaver()
        {
            InitializeComponent();
        }

        private void formScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            //press any key to close screen sceen saver
            Close();
        }

        private void formScreenSaver_Load(object sender, EventArgs e)
        {

        }
    }
}
