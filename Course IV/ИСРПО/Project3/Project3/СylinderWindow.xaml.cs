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
    /// Логика взаимодействия для СylinderWindow.xaml
    /// </summary>
    public partial class СylinderWindow : Window
    {
        public СylinderWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InoutRaduisTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //VTextBox.Text = System.Convert.ToString((4 / 3) * Math.PI * Math.Pow(System.Convert.ToDouble(InputRaduisTextbox.Text), 3));
            STextBox.Text = System.Convert.ToString(4 * Math.PI * Math.Pow(System.Convert.ToDouble(InputRaduisTextbox.Text), 2));
        }
    }
}
