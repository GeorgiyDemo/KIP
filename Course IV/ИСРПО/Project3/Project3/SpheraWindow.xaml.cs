using System;
using System.Windows;
using System.Windows.Controls;

namespace Project3
{
    /// <summary>
    /// Логика взаимодействия для SpheraWindow.xaml
    /// </summary>
    public partial class SpheraWindow : Window
    {
        public SpheraWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InoutRaduisTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            VTextBox.Text = System.Convert.ToString((4 / 3) * Math.PI * Math.Pow(System.Convert.ToDouble(InputRaduisTextbox.Text), 3));
            STextBox.Text = System.Convert.ToString(4 * Math.PI * Math.Pow(System.Convert.ToDouble(InputRaduisTextbox.Text), 2));
        }

    }
}
