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
            if ((double.TryParse(InputRaduisTextbox.Text, out InputR)) && (double.TryParse(HTextBox.Text, out InputH)))
            {
                CylinderClass Cylinder_obj = new CylinderClass(InputR, InputR);

                S1TextBox.Text = Cylinder_obj.Get1Value();
                S2TextBox.Text = Cylinder_obj.Get2Value();
                VTextBox.Text = Cylinder_obj.Get3Value();

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
