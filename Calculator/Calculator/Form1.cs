using System;
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
        bool plus = false;
        bool minus = false;
        bool multiple = false;
        bool divide = false;
        bool percent = false;
        bool memory = false;
        double memStor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            percent = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memStor = 0;
            memory = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memory)
            {
                textBox1.Text = Convert.ToString(memStor);
            }
            else
            {
                textBox1.Text = "Memory is empty!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!memory)
            {
                memory = true;
                memStor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                memStor += Convert.ToDouble(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!memory)
            {
                memory = true;
                memStor = Convert.ToDouble(textBox1.Text)*(-1);
                textBox1.Text = "";
            }
            else
            {
                memStor += Convert.ToDouble(textBox1.Text) * (-1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text)*(-1);
            textBox1.Text = Convert.ToString(x);
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            double x;
            x = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(x);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            divide = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            multiple = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x;
            x = 1 / (Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(x);
        }       

        private void button24_Click(object sender, EventArgs e)
        {
            plus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            minus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                if (percent)
                {
                    double del = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Tag)) / 100.0;
                    del = Convert.ToDouble(textBox1.Tag) + del;
                    textBox1.Text = del.ToString();
                }
                else
                {
                    decimal del = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = del.ToString();
                }
            }
            if (minus)
            {
                if (percent)
                {
                    decimal del = (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag)) / 100;
                    del = Convert.ToDecimal(textBox1.Tag) - del;
                    textBox1.Text = del.ToString();
                }
                else
                {
                    decimal del = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = del.ToString();
                }
            }
            if (multiple)
            {
                if (percent)
                {
                    decimal del = (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag)) / 100;
                    del = Convert.ToDecimal(textBox1.Tag) * del;
                    textBox1.Text = del.ToString();
                }
                else
                {
                    decimal del = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag);
                    textBox1.Text = del.ToString();
                }
            }
            if (divide)
            {
                if (percent)
                {
                    decimal del = (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag)) / 100;
                    del = Convert.ToDecimal(textBox1.Tag) / del;
                    textBox1.Text = del.ToString();
                }
                else
                {
                    decimal del = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = del.ToString();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

    }
}
