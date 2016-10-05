using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s;
        double a, b, result;
        string symbol;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            b = Convert.ToDouble(textBox1.Text);
            switch (symbol)
            {
                case "+":
                    {
                        result = a + b;
                        textBox2.Text = Convert.ToString(result);
                        break;
                    }
                case "/": if (b == 0)
                            {
                            textBox1.Text = "000";
                            break;
                            }
                        else
                            {
                            result = a / b;
                            textBox2.Text = Convert.ToString(result);
                            break;
                            }
                case "*": if (b == 0)
                    {
                        textBox1.Text = "000";
                        break;
                    }
                    else
                    {
                        result = a * b;
                        textBox2.Text = Convert.ToString(result);
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        textBox2.Text = Convert.ToString(result);
                        break;
                    }
            }
        }



        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbol = "/";
            textBox1.Clear();



        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbol = "+";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbol = "*";
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbol = "-";
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            string x;
            x=s.Remove(s.Length-1,1);
            textBox1.Text = x;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
