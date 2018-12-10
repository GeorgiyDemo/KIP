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
using System.Windows.Shapes;

namespace Project3
{
    /// <summary>
    /// Логика взаимодействия для ConusWindow.xaml
    /// </summary>
    public partial class ConusWindow : Window
    {
        public ConusWindow()
        {
            InitializeComponent();
        }
         
        //Проверка ввода
        private void CheckData()
        {
            double InputR, InputH, InputL;
            if (double.TryParse(InputRTextbox.Text, out InputR) && double.TryParse(InputHTextBox.Text, out InputH))
            {
                InputL = Math.Sqrt(Math.Pow(InputR, 2) * Math.Pow(InputH, 2));
                Vmain.Text = Convert.ToString(Math.Round(InputH * 1 / 3 * Math.PI * Math.Pow(InputR, 2), 3));
                Smain1.Text = Convert.ToString(Math.Round(Math.PI * InputR * InputR, 3));
                Smain2.Text = Convert.ToString(Math.Round(Math.PI * InputR * InputL, 3));
                Smain3.Text = Convert.ToString(Math.Round(Math.PI * InputR * (InputR + InputL), 3));

            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InputRTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }

        private void InputLTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }

        private void InputHTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }
    }
}
