﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConverter
{
    public partial class currencyConvert : Form
    {
        public currencyConvert()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            btnConverter.Navigate("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");
        }
    }
}
