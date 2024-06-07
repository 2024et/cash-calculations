using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox9.Text) && textBox9.Text != "0")
            {
                int number5 = int.Parse(textBox9.Text);
                int realize5 = number5 * 5;
                string realizesttring5 = realize5.ToString();
                label21.Text = realizesttring5;
            }
            else
            {
                label21.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                int number10000 = int.Parse(textBox1.Text);
                int realize10000 = number10000 * 10000;
                string realizesttring10000 = realize10000.ToString();
                label13.Text = realizesttring10000;
            }
            else
            {
                label13.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && textBox2.Text != "0")
            {
                int number5000 = int.Parse(textBox1.Text);
                int realize5000 = number5000 * 5000;
                string realizesttring5000 = realize5000.ToString();
                label14.Text = realizesttring5000;
            }
            else
            {
                label14.Text = "0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && textBox3.Text != "0")
            {
                int number2000 = int.Parse(textBox1.Text);
                int realize2000 = number2000 * 2000;
                string realizesttring2000 = realize2000.ToString();
                label15.Text = realizesttring2000;
            }
            else
            {
                label15.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && textBox4.Text != "0")
            {
                int number1000 = int.Parse(textBox1.Text);
                int realize1000 = number1000 * 1000;
                string realizesttring1000 = realize1000.ToString();
                label16.Text = realizesttring1000;
            }
            else
            {
                label16.Text = "0";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox5.Text) && textBox5.Text != "0")
            {
                int number500 = int.Parse(textBox5.Text);
                int realize500 = number500 * 500;
                string realizesttring500 = realize500.ToString();
                label17.Text = realizesttring500;
            }
            else
            {
                label17.Text = "0";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text) && textBox6.Text != "0")
            {
                int number100 = int.Parse(textBox6.Text);
                int realize100 = number100 * 100;
                string realizesttring100 = realize100.ToString();
                label18.Text = realizesttring100;
            }
            else
            {
                label18.Text = "0";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox7.Text) && textBox7.Text != "0")
            {
                int number50 = int.Parse(textBox7.Text);
                int realize50 = number50 * 50;
                string realizesttring50 = realize50.ToString();
                label19.Text = realizesttring50;
            }
            else
            {
                label19.Text = "0";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && textBox8.Text != "0")
            {
                int number10 = int.Parse(textBox8.Text);
                int realize10 = number10 * 10;
                string realizesttring10 = realize10.ToString();
                label20.Text = realizesttring10;
            }
            else
            {
                label20.Text = "0";
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox10.Text) && textBox10.Text != "0")
            {
                label22.Text = textBox10.Text;
            }
            else
            {
                label22.Text = "0";
            }
        }

      

        private void label23_Click(object sender, EventArgs e)
        {

        }

        

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = label13.Text;
            int a13 = int.Parse(a);
            string b = label14.Text;
            int b13 = int.Parse(b);
            string c = label15.Text;
            int c13 = int.Parse(c);
            string d = label16.Text;
            int d13 = int.Parse(d);
            string f = label17.Text;
            int f13 = int.Parse(f);
            string g = label18.Text;
            int g13 = int.Parse(g);
            string h = label19.Text;
            int h13 = int.Parse(h);
            string i = label20.Text;
            int i13 = int.Parse(i);
            string j = label21.Text;
            int j13 = int.Parse(j);
            string k = label22.Text;
            int k13 = int.Parse(k);

            int realize = a13 + b13 + c13 + d13 + f13 + g13 + h13 + i13 + j13 + k13;

            string realizestring = realize.ToString();

            label23.Text = realizestring;
        }
    }
}
