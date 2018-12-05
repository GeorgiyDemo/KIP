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
            ResultStringTextBox.Text = "";
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
            else if (ContainsRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.ContainsMethod();
            else if (EndsWithRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.EndsWithMethod();
            else if (LastIndexOfRadiobutton.IsChecked == true)
                ResultStringTextBox.Text = obj.LastIndexMethod();

        }
        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RadioCheck();
            }
            catch (Exception)
            {

            }
        }

        private void ToUpperRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondStringTextBox.Visibility = Visibility.Hidden;
            SecondLabel.Visibility = Visibility.Hidden;
        }

        private void ToLowerRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondStringTextBox.Visibility = Visibility.Hidden;
            SecondLabel.Visibility = Visibility.Hidden;
        }

        private void SubstringTrimRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Подсторка";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void SplitRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Разделитель";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void JoinRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Разделитель";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void ReplaceRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Символ для замены";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void InsertRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка №1";
            SecondLabel.Content = "[Ввод] Строка №2";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void IndexOfRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Подстрока";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void CopyToRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка №1";
            SecondLabel.Content = "[Ввод] Строка №2";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void CompareNotLocaleRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка №1";
            SecondLabel.Content = "[Ввод] Строка №2";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void ContainsRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Подстрока";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void EndsWithRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Подстрока";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }

        private void LastIndexOfRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            FirstLabel.Content = "[Ввод] Строка";
            SecondLabel.Content = "[Ввод] Подстрока";
            SecondStringTextBox.Visibility = Visibility.Visible;
            SecondLabel.Visibility = Visibility.Visible;
        }
    }
}
