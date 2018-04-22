using System;
using System.Windows;

namespace IntegerArithmetic
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            intOne.Text = int.MaxValue.ToString();
            intTwo.Text = "2";
        }

        private void DoMultiply_Click(object sender, RoutedEventArgs e)
        {
            int x; int y;

            if (!int.TryParse(intOne.Text, out x))
                labelAnswer.Content = "First value not an integer";

            if (!int.TryParse(intTwo.Text, out y))
                labelAnswer.Content = "Second value not an integer";

            try
            {
                labelAnswer.Content = (x * y).ToString();
                throw new OverflowException();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
