﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDigitalClock
{
    public partial class DigitalClock : Form
    {
        Timer t = new Timer();
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {

        }
    }
}
