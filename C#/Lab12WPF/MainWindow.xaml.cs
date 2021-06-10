using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab12WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const int COLVO = 16;
        static int[] numbers = new int[COLVO];
        static Button[] buttons = new Button[COLVO];
        static int lastB = 0;
        Label Congrats = new Label();
        Canvas canva = new Canvas();       
       
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
        void Reset()
        {
            canva.Children.Clear();
            lastB = 0;
            numbers = new int[COLVO];
            NumbersSet();
            buttons = new Button[COLVO];
            OutputButton();
            canva.Children.Add(Congrats);
        }
        void Mix()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double x = buttons[i].Margin.Left;
                    double y = buttons[i].Margin.Top;

                    buttons[i].Margin = new Thickness(buttons[j].Margin.Left, buttons[j].Margin.Top, 0, 0);
                    buttons[j].Margin = new Thickness(x, y, 0, 0);
                }
            }
        }
        void OutputButton()
        {
            for (int i = 0, j = 0, k = 0; i < buttons.Length; i++, j++)
            {
                if (j == 4)
                {
                    j = 0;
                    k++;
                }

                buttons[i] = new Button();
                buttons[i].Content = numbers[i].ToString();
                buttons[i].Width = 45;
                buttons[i].Height = 45;
                buttons[i].Margin = new Thickness(k * 45 + 5, j * 45 + 5, 0, 0);

                buttons[i].Click += (s, e) =>
                {
                    Congrats.Visibility = Visibility.Hidden;
                    Mix();

                    Button temp = s as Button;
                    int num = Int16.Parse(temp.Content.ToString());

                    (temp).Visibility = Visibility.Hidden;

                    if (lastB != num - 1)
                    {
                        Reset();
                    }
                    else if (num == 16)
                    {
                        Reset();
                        Congrats.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lastB = num;
                    }
                };
                canva.Children.Add(buttons[i]);
            }

            tabPage2.Content = canva;
        }
        public MainWindow()
        {
            InitializeComponent();


            NumbersSet();            
            Congrats.Content = "Winner!";
            Congrats.Margin = new Thickness(20, 247, 0, 0);
            Congrats.FontSize = 18;
            Congrats.Foreground = Brushes.LimeGreen;
            Congrats.Visibility = Visibility.Hidden;
            
            canva.Children.Add(Congrats);

            OutputButton();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
           
            if (AddBox != null)
            {

                comboBox1.Items.Add(AddBox.Text);
                AddBox.Text = "";
            }
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
            
        }
      
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(AddBox.Text != "")
            {
                comboBox1.Items.Remove(AddBox.Text);
                AddBox.Text = "";
            }
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Remove(comboBox1.Text);
            }
        }
    }
}
