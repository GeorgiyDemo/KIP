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

namespace DatabaseApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ValidFirst, ValidSecond, ValidThird, ValidEmail, ValidPhone, ValidAge = false;
        int result = 0;
        static string[] RegonStrings = {"Адыгея", "Алтай","Бурятия","Карелия","Москва","Марий Эл","Мордовия","Москва"};
        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidationClass.IsValidEmail(EmailTextBox.Text) == true)
            {
                EmailTextBox.Foreground = Brushes.Black;
                ValidEmail = true;
            }
            else
            {
                EmailTextBox.Foreground = Brushes.Red;
                ValidEmail = false;
            }
            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge == true);
        }

        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidationClass.IsPhoneNumber(PhoneTextBox.Text) == true)
            {
                PhoneTextBox.Foreground = Brushes.Black;
                ValidPhone = true;
            }
            else
            {
                ValidPhone = false;
                PhoneTextBox.Foreground = Brushes.Red;
            }

            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge == true);
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Int32.TryParse(AgeTextBox.Text, out int bufint))
            {
                AgeTextBox.Foreground = Brushes.Black;
                ValidAge = true;
            }
            else
            {
                AgeTextBox.Foreground = Brushes.Red;
                ValidAge = false;
            }
            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge == true);
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            for (int i = 0; i < RegonStrings.Length - 1; i++)
                RegionsComboBox.Items.Add(RegonStrings[i]);

            int firstnum = Convert.ToInt32(ValidationClass.GetRandomNumber());
            int secondnum = Convert.ToInt32(ValidationClass.GetRandomNumber());
            result = secondnum + firstnum;
            CaptchaLabel.Content = firstnum.ToString() + "+" + secondnum.ToString()+"=";
        }

        private void ThirdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ThirdTextBox.Text != "")
                ValidThird = true;
            else
                ValidThird = false;

            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge = true);
        }

        private void SecondTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SecondTextBox.Text != "")
                ValidSecond = true;
            else
                ValidSecond = false;


            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge = true);
        }

        private void FirstTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FirstTextBox.Text != "")
                ValidFirst = true;
            else
                ValidFirst = false;

            EnterButton.IsEnabled = (ValidFirst == true) && (ValidSecond == true) && (ValidThird == true) && (ValidEmail == true) && (ValidPhone == true) && (ValidAge = true);
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if ((RegionsComboBox.SelectedIndex != -1) && (CollegeNameTextBox.Text != "") && (FirstRadioButton.IsChecked==true || SecondRadioButton.IsChecked == true) && (CollegecourseTextBox.Text != ""))
            {
                if ((CaptchaTextBox.Text) == result.ToString())
                {
                    string CollegeProfession = (FirstRadioButton.IsChecked == true) ? "09.02.03" : "10.02.03";
                    StoreArrayClass.AddValues(FirstTextBox.Text, SecondTextBox.Text, ThirdTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text, AgeTextBox.Text, RegionsComboBox.Text, CollegeNameTextBox.Text, CollegeProfession, CollegecourseTextBox.Text);
                    OtherWindow obj = new OtherWindow();
                    obj.Show();
                }
                else
                    MessageBox.Show("Неверная капча");
            }
            else
            {
                MessageBox.Show("Проверьте корректность данных!");
            }
        }

    }
}
