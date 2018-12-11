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

        private void CheckData()
        {
            double InputR, InputH;
            try
            {
                if ((double.TryParse(InputRaduisTextbox.Text, out InputR)) && (double.TryParse(HTextBox.Text, out InputH)))
                {

                    S1TextBox.Text = Convert.ToString(Math.Round(2 * Math.PI * InputR * InputH, 3));
                    S2TextBox.Text = Convert.ToString(Math.Round(2 * Math.PI + 2 * Math.PI * Math.Round(InputR, 2), 3));
                    VTextBox.Text = Convert.ToString(Math.Round(InputH * Math.PI * Math.Round(InputR, 2), 3));


                }
            }
            catch (Exception)
            {

            }
        }

        private void InoutRaduisTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }

        private void HTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }
    }
}
