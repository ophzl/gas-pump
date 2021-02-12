using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Essence2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fuelChoice = "";
        Boolean ticket = false;
        Boolean duplicata = false;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            button1.Hide();
            label4.Visible = true;
            Thread.Sleep(2000);
            label4.Hide();
            fuelChoice1.Visible = true;
        }

        private void fuelChoice1_Load(object sender, EventArgs e)
        {
            fuelChoice1.onClick += FuelChoice1_onClick;
        }

        private void FuelChoice1_onClick(string txt)
        {
            fuelChoice = txt;
            fuelChoice1.Hide();
            cardCode1.Visible = true;
            textBox1.Visible = true;
        }

        private void cardCode1_Load(object sender, EventArgs e)
        {
            cardCode1.onClick += CardCode1_onClick;
        }

        private void CardCode1_onClick(string txt)
        {
            const string code = "1234";

            switch(txt)
            {
                case "V":
                    if(textBox1.Text == code)
                    {
                        textBox1.Text = "Code Bon";
                        cardCode1.Hide();
                        textBox1.Hide();
                        Thread.Sleep(2000);
                        ticketChoice1.Visible = true;
                    }
                    else
                    {
                        textBox1.Text = "Code Faux";
                    }
                    break;
                case "X":
                    textBox1.Clear();
                    break;
                default:
                    textBox1.Text += txt;
                    break;
            }
        }

        private void ticketChoice1_Load(object sender, EventArgs e)
        {
            ticketChoice1.onClick += TicketChoice1_onClick;
        }

        private void TicketChoice1_onClick(string txt)
        {

            switch (txt)
            {
                case "AVEC TICKET":
                    ticket = true;
                    ticketChoice1.Hide();
                    checkout1.Visible = true;
                    button2.Visible = true;
                    label5.Visible = true;
                    label7.Visible = true;
                    label6.Text = fuelChoice;
                    label6.Visible = true;
                    break;
                case "TICKET + DUPLICATA":
                    ticket = true;
                    duplicata = true;
                    ticketChoice1.Hide();
                    checkout1.Visible = true;
                    button2.Visible = true;
                    label5.Visible = true;
                    label7.Visible = true;
                    label6.Text = fuelChoice;
                    label6.Visible = true;
                    break;
                case "SANS TICKET":
                    ticketChoice1.Hide();
                    checkout1.Visible = true;
                    button2.Visible = true;
                    label5.Visible = true;
                    label7.Visible = true;
                    label6.Text = fuelChoice;
                    label6.Visible = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Hide();
            button2.Hide();
            Thread.Sleep(1500);
            checkout1.Hide();
            service1.Visible = true;
            label8.Text = fuelChoice;
            label8.Visible = true;
            label9.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            service1.Hide();
            label8.Hide();
            label9.Hide();
            label10.Visible = true;
            button4.Visible = true;
        }

        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Hide();
            button4.Hide();
            label11.Text = RandomNumber(40, 150).ToString() + " EUR";
            if (ticket && !duplicata)
            {
                pleaseWait1.Visible = true;
                label11.Visible = true;
            }
            else if (duplicata)
            {
                pleaseWaitDuplicata1.Visible = true;
                label11.Visible = true;
                Thread.Sleep(2000);
                pleaseWait1.Hide();
                label11.Hide();
            }
            else
            {
                thanks1.Visible = true;
                label11.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                c.Hide();
            InitializeComponent();
        }
    }
}
