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

namespace FormulaProject
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

        public  void OutResult(int D, int K)
        {
            ResultLabel.Content = "";
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                ResultLabel.Content += ((i * D + K) / (D - K)).ToString()+"\n";
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if ((FirstInput.Text != "") && (SecondInput.Text != ""))
                OutResult(Convert.ToInt32(FirstInput.Text), Convert.ToInt32(SecondInput.Text));
        }
    }
}
