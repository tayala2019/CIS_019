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
            string[] images = System.IO.Directory.GetFiles("pics");
            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));
            }
            for (int i = 0; i < 50;i++)
            {
                PeacePic np = new PeacePic();
                np.PicNum = i % BGImages.Count;
                np.X = rand.Next(0, Width);
                np.Y = rand.Next(0, Height);

                // np.Speed = rand.Next(100, 300) / 100.0f;
                PeacePics.Add(np);
            }
        }
    }
}
