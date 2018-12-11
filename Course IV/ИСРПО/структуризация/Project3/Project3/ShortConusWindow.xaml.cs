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
            try
            {
                if (Double.TryParse(InputRTextbox.Text, out InputR) && Double.TryParse(InputrTextBox.Text, out Inputr) && Double.TryParse(InputHTextBox.Text, out InputH) && Double.TryParse(InputLTextBox.Text, out InputL))
                {
                    ShortConusClass ShortConus_obj = new ShortConusClass(InputR, Inputr, InputH, InputL);

                    Soutput1.Text = ShortConus_obj.Get1Value();
                    Soutput2.Text = ShortConus_obj.Get2Value();
                    Soutput3.Text = ShortConus_obj.Get3Value();
                    Soutput4.Text = ShortConus_obj.Get4Value();
                    Voutput.Text = ShortConus_obj.GetVValue();

                }
            }
            catch (Exception)
            {

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
