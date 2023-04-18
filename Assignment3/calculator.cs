using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        double result;
        double firstdigit;
        string abbb;
        bool isoptr = false;



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (abbb)
            {
                case "+":
                    textBox.Text = (firstdigit + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (firstdigit - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (firstdigit * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (firstdigit / double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
                textBox.Text += button.Text;
        }
    }
}
