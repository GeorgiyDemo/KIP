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

            StringClass obj = new StringClass(FirstStringTextBox.Text, SecondStringTextBox.Text);
            SecondStringTextBox.Text = ResultStringTextBox.Text = FirstStringTextBox.Text = "";
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
            else if (InsertRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.InsertMethod();
            else if (IndexOfRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.IndexOfMethod();
            else if (CopyToRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.CopyToMethod();

        }
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            RadioCheck();
        }
    }
}
