using System;
using System.Windows;
using System.Windows.Controls;


namespace NormalProgramma
{
    /// <summary>
    /// Логика взаимодействия для Konyc.xaml
    /// </summary>
    public partial class Konyc : Window
    {
        public Konyc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow MainWindow_obj = new MainWindow();
            MainWindow_obj.Show();
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



        private void clear()
        {
            l4.Visibility = Visibility.Hidden;
            l5.Visibility = Visibility.Hidden;
            l6.Visibility = Visibility.Hidden;
            l7.Visibility = Visibility.Hidden;
            txt_4.Clear();
            txt_5.Clear();
            txt_6.Clear();
            txt_7.Clear();
        }
    
        private void ypr()
        {
            double r = 0, h = 0, l = 0;
            clear();
           
            if (Double.TryParse(txt_1.Text, out r))
            {
                txt_4.Text = Convert.ToString(Math.Round(Math.PI * r * r, 3));
            }
            else if (txt_1.Text == "")
            {
                l4.Visibility = Visibility.Visible;
            }
            else if (txt_1.Text != "" || txt_1.Text == "0." || txt_1.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {

                txt_4.Text = "";
            }
            if (Double.TryParse(txt_2.Text, out h))
            {
                if (Double.TryParse(txt_1.Text, out r) && Double.TryParse(txt_2.Text, out h))
                {
                    txt_7.Text = Convert.ToString(Math.Round(h * 1 / 3 * Math.PI * Math.Pow(r, 2), 3));
                }
                else if (txt_1.Text == "" || txt_2.Text == "")
                {
                    l7.Visibility = Visibility.Visible;
                }
            }
            else if(txt_2.Text=="") 
            {
                l7.Visibility = Visibility.Visible;
            }
            else if (txt_2.Text != "" || txt_2.Text == "0." || txt_2.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Double.TryParse(txt_3.Text, out l))
            {
                if (Double.TryParse(txt_1.Text, out r) && Double.TryParse(txt_3.Text, out l))
                {
                    txt_5.Text = Convert.ToString(Math.Round(Math.PI * r * l, 3));
                    txt_6.Text = Convert.ToString(Math.Round(Math.PI * r * (r + l), 3));
                }
                else if (txt_1.Text == "" || txt_3.Text == "")
                {
                    l5.Visibility = Visibility.Visible;
                    l6.Visibility = Visibility.Visible;
                }
            }
            else if (txt_3.Text == "")
            {
                l5.Visibility = Visibility.Visible;
                l6.Visibility = Visibility.Visible;
            }
            else if (txt_3.Text != "" || txt_3.Text == "0." || txt_3.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
