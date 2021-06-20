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
using System.Windows.Threading;

namespace lb6

{

    public partial class MainWindow : Window
    {
        DispatcherTimer timer1;
        DispatcherTimer timer2;
        private bool showMessage = false;
        private int counter = 1;

        public MainWindow()
        {
            InitializeComponent();
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer_tick);
            timer1.Interval = new TimeSpan(0, 0, 3);
            timer1.Start();
            timer2 = new DispatcherTimer();
            timer2.Tick += new EventHandler(timer2_tick);
            timer2.Interval = new TimeSpan(0, 0, 1);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timer1.Interval = new TimeSpan(0, 0, 1);
            if (showMessage)
            {
                base.Title = "Press 'OK' button";
                showMessage = false;
            }
            else
            {
                base.Title = "";
                showMessage = true;
            }
            counter++;
            if (counter > 8)
            {
                timer1.Stop();
                showMessage = false;
            }
        }

        private void timer2_tick(object sender, EventArgs e)
        {
            if (showMessage)
            {
                base.Title = "'OK' will never be pressed!";
                showMessage = false;
            }
            else
            {
                base.Title = "";
                showMessage = true;
            }
            counter++;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (button1.Margin.Left < 1)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 100, button1.Margin.Top, 0, 0);
            }
            if (button1.Margin.Left + button1.Width + 10 > base.Width)
            {
                button1.Margin = new Thickness(base.Width - 100 - button1.Width, button1.Margin.Top, 0, 0);
            }
            if (button1.Margin.Top < 1)
            {
                button1.Margin = new Thickness(button1.Margin.Left, button1.Margin.Top + 100, 0, 0);
            }
            if (button1.Margin.Top + button1.Height + 40 > base.Height)
            {
                button1.Margin = new Thickness(button1.Margin.Left, base.Height - 100 - button1.Height, 0, 0);
            }
            if (e.GetPosition(c).X > button1.Margin.Left - 20
                && e.GetPosition(c).Y > button1.Margin.Top - 20
                && e.GetPosition(c).X < button1.Margin.Left + button1.Width / 2
                && e.GetPosition(c).Y < button1.Margin.Top + button1.Height / 2)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 1, button1.Margin.Top + 1, 0, 0);
                changeSize();
            }
            if (e.GetPosition(c).X > button1.Margin.Left - 15
                && e.GetPosition(c).X < button1.Margin.Left + button1.Width / 2
                && e.GetPosition(c).Y > button1.Margin.Top + button1.Height / 2
                && e.GetPosition(c).Y < button1.Margin.Top + button1.Height + 20)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 5, button1.Margin.Top - 5, 0, 0);
                changeSize();
            }
            if (e.GetPosition(c).X > button1.Margin.Left + button1.Width / 2
                && e.GetPosition(c).X < button1.Margin.Left + button1.Width + 20
                && e.GetPosition(c).Y > button1.Margin.Top + button1.Height / 2
                && e.GetPosition(c).Y < button1.Margin.Top + button1.Height + 20)
            {
                button1.Margin = new Thickness(button1.Margin.Left - 5, button1.Margin.Top - 5, 0, 0);
                changeSize();
            }
            if (e.GetPosition(c).X > button1.Margin.Left + button1.Width / 2
                && e.GetPosition(c).X < button1.Margin.Left + button1.Width + 20
                && e.GetPosition(c).Y < button1.Margin.Top + button1.Height / 2
                && e.GetPosition(c).Y > button1.Margin.Top - 20)
            {
                button1.Margin = new Thickness(button1.Margin.Left - 5, button1.Margin.Top + 5, 0, 0);
                changeSize();
            }
        }

        private void changeSize()
        {
            if (button1.Width > 0.1 && button1.Height > 0.1)
            {
                button1.Width = button1.Width - 0.1;
                button1.Height = button1.Height - 0.1;
            }
            else
            {
                button1.Visibility = Visibility.Hidden;
                timer2.Start();
                timer2_tick(null, null);
            }
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            button1.Margin = new Thickness(button2.Margin.Left + 200, button2.Margin.Top + 200, 0, 0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 'OK' has been clicked");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
