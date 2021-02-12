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
    public partial class TicketChoice : UserControl
    {
        public TicketChoice()
        {
            InitializeComponent();
        }

        public delegate void btnClick(string txt);
        public event btnClick onClick;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }
    }
}
