using System;

using System.Windows;
using System.Windows.Controls;

namespace NormalProgramma
{
    /// <summary>
    /// Логика взаимодействия для Shar.xaml
    /// </summary>
    public partial class Shar : Window
    {
        public Shar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double r = 0;
            if (txt_1.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Малкеров Геннадий", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_2.Text = "";
                txt_3.Text = "";
                return;
            }
            if (double.TryParse(txt_1.Text,out r))
            {
               txt_2.Text="";
                txt_2.Text = Convert.ToString(Math.Round( 4 / 3 * Math.PI *Math.Pow(r,3),3));
                txt_3.Text = "";
                txt_3.Text = Convert.ToString(Math.Round( 4*Math.PI*r*r,3));

            }
            else if(txt_1.Text != ""||txt_1.Text=="0."||txt_1.Text=="0,")
            {

                MessageBox.Show("Введите корректные данные");
                txt_2.Text = "";
                txt_3.Text = "";
            }
            else
            {
                txt_2.Text = "";
                txt_3.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow MainWindow_obj = new MainWindow();
            MainWindow_obj.Show();
        }




    }
}
