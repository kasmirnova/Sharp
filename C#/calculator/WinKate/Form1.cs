using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKate
{
    public partial class Form1 : Form
    {
        public double number = 0;
        public double summ_d = 0;
        public string engine = "";
        public bool check_error=false;
        public Form1()
        {
            InitializeComponent();
            label2.Text ="";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check_error==true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string one = "1";
            
            textBox1.Text = textBox1.Text+one;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string two = "2";
            
            textBox1.Text = textBox1.Text + two;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string three = "3";
            
            textBox1.Text = textBox1.Text + three;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string four = "4";
            
            textBox1.Text = textBox1.Text + four;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string five = "5";
            
            textBox1.Text = textBox1.Text + five;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string six = "6";
            
            textBox1.Text = textBox1.Text + six;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string seven = "7";
            
            textBox1.Text = textBox1.Text + seven;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string eight = "8";
            
            textBox1.Text = textBox1.Text + eight;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string nine = "9";
            
            textBox1.Text = textBox1.Text + nine;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (check_error == true)
            {
                textBox1.Text = "";
                check_error = false;
            }
            const string zero = "0";
            
            textBox1.Text = textBox1.Text + zero;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a;
            //DELETE
            if(textBox1.Text.Length>0)
            {
                a = Convert.ToDouble(textBox1.Text);
                number = a;
                textBox1.Text = "";
                engine = "/";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double a;
            //YMNOJIT
            if (textBox1.Text.Length > 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                number = a;
                textBox1.Text = "";
                engine = "*";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a;
            //RAVNO
            if (textBox1.Text.Length > 0&&engine=="/")
            {
                a = Convert.ToDouble(textBox1.Text);
                if (a > 0 || a < 0)
                {
                    summ_d = number / a;
                    textBox1.Text = Convert.ToString(summ_d);
                }
                else
                {
                    textBox1.Text = "Ошибочка вышла";
                    check_error = true;
                }
            }
            if (textBox1.Text.Length > 0 && engine == "*")
            {
                a = Convert.ToDouble(textBox1.Text);
                summ_d = number * a;
                textBox1.Text = Convert.ToString(summ_d);

            }
            if (textBox1.Text.Length > 0 && engine == "+")
            {
                a = Convert.ToDouble(textBox1.Text);
                summ_d = number + a;
                textBox1.Text = Convert.ToString(summ_d);

            }
            if (textBox1.Text.Length > 0 && engine == "-")
            {
                a = Convert.ToDouble(textBox1.Text);
                summ_d = number - a;
                textBox1.Text = Convert.ToString(summ_d);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a;
            //PLUS
            if (textBox1.Text.Length > 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                number = a;
                textBox1.Text = "";
                engine = "+";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a;
            //Minus
            if (textBox1.Text.Length > 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                number = a;
                textBox1.Text = "";
                engine = "-";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            const string dote = ",";
            textBox1.Text = textBox1.Text + dote;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number = 0;
            summ_d = 0;
            engine = "";
            check_error = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)textBox1.Text);
        }
    }
}
