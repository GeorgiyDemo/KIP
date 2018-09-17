using System;

using System.Windows;
using System.Windows.Controls;

namespace NormalProgramma
{
    /// <summary>
    /// Interaction logic for barrelxaml.xaml
    /// </summary>
    public partial class barrelxaml : Window
    {
        public barrelxaml()
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
            if (txt_1.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }

        private void clear()
        {
            l3.Visibility = Visibility.Hidden;
            l4.Visibility = Visibility.Hidden;
            l5.Visibility = Visibility.Hidden;
            txt_3.Clear();
            txt_4.Clear();
            txt_5.Clear();
        }
         
        private void ypr()
        {
            double r = 0, h = 0;
            clear();
            if (!(Double.TryParse(txt_1.Text, out r) || txt_1.Text==""))
            {
                MessageBox.Show("Введите корректные данные1", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }

            if (Double.TryParse(txt_2.Text, out h))
            {
                if(Double.TryParse(txt_1.Text, out r))
                {
                    txt_3.Text = Convert.ToString(Math.Round(2*Math.PI*r*h, 3));
                    txt_4.Text = Convert.ToString(Math.Round(2 * Math.PI+2*Math.PI*Math.Round(r,2), 3));
                    txt_5.Text = Convert.ToString(Math.Round(h* Math.PI * Math.Round(r, 2), 3));
                }
                else
                {
                    l3.Visibility = Visibility.Visible;
                    l4.Visibility = Visibility.Visible;
                    l5.Visibility = Visibility.Visible;
                }

            }
            else if(txt_2.Text == "")
            {
                l3.Visibility = Visibility.Visible;
                l4.Visibility = Visibility.Visible;
                l5.Visibility = Visibility.Visible;
            }else if (txt_2.Text != "" || txt_2.Text == "0." || txt_2.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные2", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

 


        }
    }
}
