using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NumbersSet();

            congrats.Text = "Ну ты терпиливый!";
            congrats.Location = new Point(50, 250);
            congrats.BackColor = Color.Azure;
            congrats.Visible = false;
            tabPage2.Controls.Add(congrats);
            OutputButtons();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void Deleter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Remove(textBox1.Text);
                textBox1.Clear();
            }
        }


        public static int number_button= 16;
        public static int[] numbers = new int[number_button];
        public static Button[] buttons = new Button[number_button];
        static int lastB = 0;
        Label congrats = new Label();

        static void NumbersSet()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                do
                {
                    temp = (int)(new Random()).Next(1, 17);

                    if (!numbers.Contains<int>(temp))
                    {
                        numbers[i] = temp;
                        break;
                    }
                } while (numbers.Contains<int>(temp));
            }
        }
        void Mix()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Point p = buttons[i].Location;
                    buttons[i].Location = buttons[j].Location;
                    buttons[j].Location = p;
                }
            }
        }

        void Reset()
        {
            tabPage2.Controls.Clear();
            lastB = 0;
            numbers = new int[number_button];
            NumbersSet();
            buttons = new Button[number_button];
            OutputButtons();
            tabPage2.Controls.Add(congrats);

        }
        void OutputButtons()
        {
            int counter = 0;

            for (int i = 0, j = 0; i < 16; i++, j++)
            {
                if (j == 4)
                {
                    counter++;
                    j = 0;
                };
                buttons[i] = new Button();
                buttons[i].Size = new Size(80, 80);
                buttons[i].BackColor = Color.Black;
                buttons[i].ForeColor = Color.White;
                buttons[i].Location = new Point(counter * buttons[i].Width + 200, j * buttons[i].Height + 50);
                buttons[i].Text = numbers[i].ToString();
                buttons[i].Click += (s, e) =>
                {
                    congrats.Visible = false;
                    Mix();

                    Button temp = s as Button;
                    int num = Int16.Parse(temp.Text);

                    (temp).Visible = false;

                    if (lastB != num - 1)
                    {
                        Reset();
                    }
                    else if (num == 16)
                    {
                        Reset();
                        congrats.Visible = true;
                    }
                    else
                    {
                        lastB = num;
                    }

                };
                tabPage2.Controls.Add(buttons[i]);
            }

        }
    }
}
