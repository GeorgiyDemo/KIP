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
    /// Логика взаимодействия для ShortConusWindow.xaml
    /// </summary>
    public partial class ShortConusWindow : Window
    {
        public ShortConusWindow()
        {
            InitializeComponent();
        }

        private void CheckData()
        {
            Double InputR, Inputr, InputH, InputL;
            if (Double.TryParse(InputRTextbox.Text, out InputR) && Double.TryParse(InputrTextBox.Text, out Inputr) && Double.TryParse(InputHTextBox.Text, out InputH) && Double.TryParse(InputLTextBox.Text, out InputL))
            {
                Soutput1.Text = Convert.ToString(Math.Round(Math.PI * InputR * InputR, 3));
                Soutput2.Text = Convert.ToString(Math.Round(Math.PI * Inputr * Inputr, 3));
                Soutput3.Text = Convert.ToString(Math.Round(Math.PI * InputL * (Inputr + InputR) + Math.PI * Math.Pow(InputR, 2) + Math.PI * Math.Pow(Inputr, 2), 3));
                Soutput4.Text = Convert.ToString(Math.Round(InputH * 1 / 3 * Math.PI * (Math.Pow(Inputr, 2) + Math.Pow(InputR, 2) + Inputr * InputR), 3));
                Voutput.Text = Convert.ToString(Math.Round(Math.PI * InputL * (Inputr + InputR), 3));

            }
        }
 
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InputrTextBox_Changed(object sender, TextChangedEventArgs e)
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

        private void InputRTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckData();
        }
    }
}
