using System.Windows;
using System.Windows.Controls;

namespace GreatestCommonDivisor
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
        /// Do the GCD calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindGCD_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;
            int fifthNumber;

            if (!GetPostiveIntegerFromTextBox(integer1, out firstNumber)) return;
            if (!GetPostiveIntegerFromTextBox(integer2, out secondNumber)) return;
            if (!GetPostiveIntegerFromTextBox(integer3, out thirdNumber)) return;
            if (!GetPostiveIntegerFromTextBox(integer4, out fourthNumber)) return;
            if (!GetPostiveIntegerFromTextBox(integer5, out fifthNumber)) return;

            if (sender == findGCD)
            {
                resultEuclid.Content = "Euclid: "+GCDAlgorithms.FindGCDEuclid(firstNumber, secondNumber);
                resultStein.Content = "Stein: " + GCDAlgorithms.Stain(firstNumber, secondNumber);
            }

            if (sender == findGCD3)
                resultEuclid.Content = "Euclid: " + GCDAlgorithms.FindGCDEuclid(firstNumber, secondNumber, thirdNumber);

            if (sender == findGCD4)
                resultEuclid.Content = "Euclid: " + GCDAlgorithms.FindGCDEuclid(firstNumber, secondNumber, thirdNumber, fourthNumber);

            if (sender == findGCD5)
                resultEuclid.Content = "Euclid: " + GCDAlgorithms.FindGCDEuclid(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }

        private bool GetPostiveIntegerFromTextBox(TextBox textBox, out int i)
        {
            i = -1;
            if (int.TryParse(textBox.Text, out i))
            {
                if (i >= 0) return true;
            }
            MessageBox.Show("Not a positive integer value: " + textBox.Text);
            return false;
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            string commandText = "TEST.chm";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();

        }
    }
}
