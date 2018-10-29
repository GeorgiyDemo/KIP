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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StringApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private  void  RadioCheck()
        {
            SecondStringTextBox.Text = ResultStringTextBox.Text = FirstStringTextBox.Text = "";
            StringClass obj = new StringClass(FirstStringTextBox.Text, SecondStringTextBox.Text);
            if (ToUpperRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.ToUpperMethod();
            else if (ToLowerRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.ToLowerMethod();
            else if (SubstringTrimRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.SubstringTrimrMethod();
            else if (SplitRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.SplitMethod();
            else if (ReplaceRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.ReplaceMethod();
            else if (JoinRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.JoidMethod();


        }
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            RadioCheck();
        }
    }
}
