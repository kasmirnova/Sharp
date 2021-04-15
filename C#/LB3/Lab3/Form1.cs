using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public bool chekon = false;
        public int eight = 1;
        public Form1()
        {
            Random n = new Random();
            int k = 300;
            InitializeComponent();
            button1.TabStop = false;
            button1.Location = new Point(n.Next(550),n.Next(k));
            button1.Width = 200;
            button1.Height = 200;
            label1.Text = "";
            label1.ForeColor = Color.Transparent;
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;
            Random n = new Random();
            int k = n.Next(5);
            int eer = 15;
            int gran = 400;
            if (chekon == false)
            {
                if (button1.Width == 0 || button1.Height == 0)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "Кнопка “Ок” не може бути натиснута";
                }
                switch (k)
                {

                    case 1:
                        if (button1.Location.X < (757 - 66))
                        {
                            button1.Location = new Point(x + n.Next(eer), y + n.Next(eer));
                            button1.Width = button1.Width - n.Next(5);
                            button1.Height = button1.Height - n.Next(5);
                        }
                        else
                        {
                            button1.Location = new Point(n.Next(gran), n.Next(gran));
                        }
                        break;
                    case 2:
                        if (button1.Location.X < (757 - 66))
                        {
                            button1.Location = new Point(x - n.Next(eer), y + n.Next(eer));
                            button1.Width = button1.Width - n.Next(5);
                            button1.Height = button1.Height - n.Next(5);
                        }
                        else
                        {
                            button1.Location = new Point(n.Next(gran), n.Next(gran));
                        }
                        break;
                    case 3:
                        if (button1.Location.X < (757 - 66))
                        {
                            button1.Location = new Point(x + n.Next(eer), y - n.Next(eer));
                            button1.Width = button1.Width - n.Next(5);
                            button1.Height = button1.Height - n.Next(5);
                        }
                        else
                        {
                            button1.Location = new Point(n.Next(gran), n.Next(gran));
                        }
                        break;
                    case 4:
                        if (button1.Location.X < (757 - 66))
                        {
                            button1.Location = new Point(x - n.Next(eer), y - n.Next(eer));
                            button1.Width = button1.Width - n.Next(5);
                            button1.Height = button1.Height - n.Next(5);
                        }
                        else
                        {
                            button1.Location = new Point(n.Next(gran), n.Next(gran));
                        }
                        break;
                }
                if (button1.Left < 50)
                { button1.Left = 50; }
                if ((button1.Left + button1.Width) > this.ClientSize.Width)
                { button1.Left = this.ClientSize.Width - button1.Width; }
                if (button1.Top < 50)
                { button1.Top = 50; }
                if ((button1.Top + button1.Height) > this.ClientSize.Height)
                { button1.Top = this.ClientSize.Height - button1.Height; }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(100, 100);
            button1.Width = 200;
            button1.Height = 200;
            label1.Text = "";
            label1.ForeColor = Color.Transparent;
            chekon = false;
            eight++;
            if(eight==8)
            {
                label2.Text= "НАЖМИ УЖЕ ОК!!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Text = "Кнопка ОК була натиснута!";
            chekon = true;
            eight = 0;
            label2.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) //если нажали стрелку
                e.IsInputKey = true;
        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) //если нажали стрелку
                e.IsInputKey = true;
        }

        private void button3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) //если нажали стрелку
                e.IsInputKey = true;
        }
    }
}
