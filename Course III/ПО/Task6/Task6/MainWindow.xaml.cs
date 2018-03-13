using System;
using System.Text;
using System.Windows;

namespace Task6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            String meow = InputTextBox.Text;
            int i = 0;

          if (!(int.TryParse(meow,out i))){
                MessageBox.Show("TextBox не содержит целое число");
                return;
            }

          if (i < 0){
                MessageBox.Show("Введите положительное число или ноль");
            }

            int remainder = 0;

            StringBuilder binary = new StringBuilder();
            do
            {
                remainder = i % 2;
                i /= 2;
                binary.Insert(0, remainder.ToString());

            } while (i > 0);
            BinaryLabel.Content = binary.ToString();

            /*
             * А можно просто в одну строчку, но это не по учебной программе
             * BinaryLabel.Content = Convert.ToString(Convert.ToInt32(InputTextBox.Text), 2);
             */
            
        }
    }
}
