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
using StressTest;

namespace Structures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // TODO - Declare a TestCaseResult array

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create some sample Test Case Results and display
        /// in a ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void RunTests_Click(object sender, RoutedEventArgs e)
        {
            reasonsList.Items.Clear();

            // Fill the array with 10 TestCaseResult objects.

            int passCount = 0;
            int failCount = 0;

            // TODO - Display the TestCaseResult data.

            successLabel.Content = "Successes: " + passCount;
            failureLabel.Content = "Failures: " + failCount;
        }
    }
}
