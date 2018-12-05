using System;

using System.Windows;
using System.Windows.Controls;


namespace NormalProgramma
{
    /// <summary>
    /// Логика взаимодействия для Ycechkonyc.xaml
    /// </summary>
    public partial class Ycechkonyc : Window
    {
        public Ycechkonyc()
        {
            InitializeComponent();
        }

        private void txt_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_1.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }

        private void txt_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_2.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }

        private void txt_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_3.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }
        
        private void txt_4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_4.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow MainWindow_obj = new MainWindow();
            MainWindow_obj.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow MainWindow_obj = new MainWindow();
            MainWindow_obj.Show();
        }

        private void clear()
        {
            l5.Visibility = Visibility.Hidden;
            l6.Visibility = Visibility.Hidden;
            l7.Visibility = Visibility.Hidden;
            l8.Visibility = Visibility.Hidden;
            l9.Visibility = Visibility.Hidden;
            txt_5.Clear();
            txt_6.Clear();
            txt_7.Clear();
            txt_8.Clear();
            txt_9.Clear();
        }
        private void ypr()
        {
            double r = 0, h = 0, l = 0, R = 0;
            clear();

            if (Double.TryParse(txt_1.Text, out R))
            {
                txt_5.Text = Convert.ToString(Math.Round(Math.PI * R * R, 3));
            }
            else if (txt_1.Text == "")
            {
                l5.Visibility = Visibility.Visible;
            }
            else if (txt_1.Text != "" || txt_1.Text == "0." || txt_1.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                txt_5.Text = "";
            }


            if (Double.TryParse(txt_2.Text, out r))
            {
                txt_6.Text = Convert.ToString(Math.Round(Math.PI * r * r, 3));
            }
            else if (txt_2.Text == "")
            {
                l6.Visibility = Visibility.Visible;
            }
            else if (txt_2.Text != "" || txt_2.Text == "0." || txt_2.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                txt_6.Text = "";
            }


            if (Double.TryParse(txt_3.Text, out h))
            {
                if (Double.TryParse(txt_2.Text, out r) && Double.TryParse(txt_1.Text, out R))
                {
                    txt_8.Text = Convert.ToString(Math.Round(h * 1 / 3 * Math.PI * (Math.Pow(r, 2) + Math.Pow(R, 2) + r * R), 3));
                }
                else
                {
                    l8.Visibility = Visibility.Visible;
                }
            }
            else if (txt_3.Text == "")
            {
                l8.Visibility = Visibility.Visible;
            }
            else if (txt_3.Text != "" || txt_2.Text == "0." || txt_3.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                txt_8.Text = "";
            }

            if (Double.TryParse(txt_4.Text, out l))
            {
                if (Double.TryParse(txt_2.Text, out r) && Double.TryParse(txt_1.Text, out R))
                {
                    txt_7.Text = Convert.ToString(Math.Round(Math.PI * l * (r + R) + Math.PI * Math.Pow(R, 2) + Math.PI * Math.Pow(r, 2), 3));
                    txt_9.Text = Convert.ToString(Math.Round(Math.PI * l * (r + R), 3));
                }
                else
                {
                    l7.Visibility = Visibility.Visible;
                    l9.Visibility = Visibility.Visible;
                }
            }
            else if (txt_4.Text == "")
            {
                l7.Visibility = Visibility.Visible;
                l9.Visibility = Visibility.Visible;

            }
            else if (txt_3.Text != "" || txt_2.Text == "0." || txt_3.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                txt_7.Text = "";
                txt_9.Text = "";

            }
        }

        private void txt_9_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
