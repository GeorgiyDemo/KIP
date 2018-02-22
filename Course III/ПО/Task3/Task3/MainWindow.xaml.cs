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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

            ResultBox.Text = Convert.ToString(a + b);

        }

        private void FirstBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(FirstBox.Text);
            }
            catch {
                a = 0;
            }
        }

        private void SecondBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(SecondBox.Text);
            }
            catch
            {
                b = 0;
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = Convert.ToString(a - b);
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = Convert.ToString(a * b);
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = Convert.ToString(a / b);
        }
    }
}
