using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegerArithmetic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize our two integers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Make sure we've got a very big integer ready to go
            intOne.Text = int.MaxValue.ToString();
            intTwo.Text = "2";
        }

        /// <summary>
        /// Do the integer multiplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoMultiply_Click(object sender, RoutedEventArgs e)
        {
            int x; int y;

            // Check we've got integers in the textboxes
            if (!int.TryParse(intOne.Text, out x))
            {
                labelAnswer.Content = "First value not an integer";
                return;
            }
            if (!int.TryParse(intTwo.Text, out y))
            {
                labelAnswer.Content = "Second value not an integer";
                return;
            }

            // TODO - Place the multiplication in a checked block
            labelAnswer.Content = (x * y).ToString();
        }
    }
}
