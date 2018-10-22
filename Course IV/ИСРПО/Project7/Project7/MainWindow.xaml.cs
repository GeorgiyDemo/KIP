     using System;
using System.Windows;

namespace Project7
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


        private void DataGrid_Initialized(object sender, EventArgs e)
        {
            MainDataGrid.ItemsSource = ArrayClass.DataGridInput(true).DefaultView;
        }

        private void MainDiagonalSum_Initialized(object sender, EventArgs e)
        {
            MainDiagonalSum.Content = "Сумма элементов: " + ArrayClass.MainDiagonalSum().ToString();
        }

        private void MainDiagonaMin_Initialized(object sender, EventArgs e)
        {
            MainDiagonaMin.Content = "Минимальный элемент: " + ArrayClass.MainDiagonalMin().ToString();
        }

        private void MainDiagonalMax_Initialized(object sender, EventArgs e)
        {
            MainDiagonalMax.Content = "Максимальный элемент: " + ArrayClass.MainDiagonalMax().ToString();
        }

        private void AlterDiagonalSum_Initialized(object sender, EventArgs e)
        {
            AlterDiagonalSum.Content = "Сумма элементов: " + ArrayClass.AlterDiagonalSum().ToString();
        }

        private void AlterDiagonaMin_Initialized(object sender, EventArgs e)
        {
            AlterDiagonaMin.Content = "Минимальный элемент: " + ArrayClass.AlterDiagonalMin().ToString();
        }

        private void AlterDiagonalMax_Initialized(object sender, EventArgs e)
        {
            AlterDiagonalMax.Content = "Максимальный элемент: " + ArrayClass.AlterDiagonalMax().ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpTriforceSum.Content = "Сумма элементов: " + ArrayClass.UpTriforceSum().ToString();
        }

       
      
    }
}
