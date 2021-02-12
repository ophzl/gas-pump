﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essence2
{
    public partial class FuelChoice : UserControl
    {
        public FuelChoice()
        {
            InitializeComponent();
        }

        public delegate void btnClick(string txt);
        public event btnClick onClick;

        private void button1_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }
    }
}
