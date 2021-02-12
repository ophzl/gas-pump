using System;
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
    public partial class CardCode : UserControl
    {
        public CardCode()
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

        private void button4_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }
    }
}
