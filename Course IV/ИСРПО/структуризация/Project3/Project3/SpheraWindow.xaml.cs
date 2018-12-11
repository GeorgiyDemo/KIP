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
            double R;
            try
            {
                if (Double.TryParse(InputRaduisTextbox.Text, out R))
                {
                    SpheraClass sphera_obj = new SpheraClass(R);
                    VTextBox.Text = sphera_obj.Get1Value();
                    STextBox.Text = sphera_obj.Get2Value();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
