using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char oprtr;
        bool cleartextbox;
        double operation1;
        int i = 0;

        List<string> rslts = new List <string> (15);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if(textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            oprtr = '+';
            cleartextbox = true;
            operation1 = Convert.ToDouble(textBox1.Text);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            oprtr = '-';
            cleartextbox = true;
            operation1 = Convert.ToDouble(textBox1.Text);
        }

        private void button_multipl_Click(object sender, EventArgs e)
        {
            oprtr = 'x';
            cleartextbox = true;
            operation1 = Convert.ToDouble(textBox1.Text);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            oprtr = '÷';
            cleartextbox = true;
            operation1 = Convert.ToDouble(textBox1.Text);
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double operation2 = Convert.ToDouble(textBox1.Text);
            double result;

            switch (oprtr)
            {
                case '+':
                    result = operation1 + operation2;
                    rslts.Add(Convert.ToString(operation1) + " + " + Convert.ToString(operation2) + " = " + Convert.ToString(result));
                    break;

                case '-':
                    result = operation1 - operation2;
                    rslts.Add(Convert.ToString(operation1) + " - " + Convert.ToString(operation2) + " = " + Convert.ToString(result));
                    break;

                case 'x':
                    result = operation1 * operation2;
                    rslts.Add(Convert.ToString(operation1) + " x " + Convert.ToString(operation2) + " = " + Convert.ToString(result));
                    break;

                case '÷':
                    result = operation1 / operation2;
                    rslts.Add(Convert.ToString(operation1) + " ÷ " + Convert.ToString(operation2) + " = " + Convert.ToString(result));
                    break;

                default:
                    result = 0;
                    break;
            }

            textBox1.Text = Convert.ToString(result);
            i++;
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                textBox1.Text = " ";
                cleartextbox = false;
            }
            textBox1.Text += ".";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int screenTextLength = textBox1.Text.Length;
                if (screenTextLength != 1)
                {
                    textBox1.Text = textBox1.Text.Remove(screenTextLength - 1);
                }
                else
                {
                    textBox1.Text = 0.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                labelH.Text += rslts[j] + "\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            labelH.Text = "";
        }
    }
}
