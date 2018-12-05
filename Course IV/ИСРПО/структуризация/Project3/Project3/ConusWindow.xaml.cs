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
            Double InputR, InputH, InputL;
            if (Double.TryParse(InputRTextbox.Text, out InputR) && Double.TryParse(InputHTextBox.Text, out InputH) && Double.TryParse(InputLTextBox.Text, out InputL))
            {
                ConusClass conus_obj = new ConusClass(InputRTextbox.Text, InputHTextBox.Text, InputLTextBox.Text);
                Vmain.Text = conus_obj.Get1Value();
                Smain1.Text = conus_obj.Get2Value();
                Smain2.Text = conus_obj.Get3Value();
                Smain3.Text = conus_obj.Get4Value();

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
