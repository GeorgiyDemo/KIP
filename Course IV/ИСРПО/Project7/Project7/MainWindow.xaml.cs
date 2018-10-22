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

            ArrayClass ArrObj = new ArrayClass();
            MainDataGrid.ItemsSource = ArrObj.DataGridInput().DefaultView;

            MainDiagonalSum.Content = "Сумма элементов: " + ArrObj.MainDiagonalSum().ToString();
            MainDiagonaMin.Content = "Минимальный элемент: " + ArrObj.MainDiagonalMin().ToString();
            MainDiagonalMax.Content = "Максимальный элемент: " + ArrObj.MainDiagonalMax().ToString();

            AlterDiagonalSum.Content = "Сумма элементов: " + ArrObj.AlterDiagonalSum().ToString();
            AlterDiagonaMin.Content = "Минимальный элемент: " + ArrObj.AlterDiagonalMin().ToString();
            AlterDiagonalMax.Content = "Максимальный элемент: " + ArrObj.AlterDiagonalMax().ToString();

            UpTriforceSum.Content = "Сумма элементов: " + ArrObj.UpTriforceSum().ToString();
            UpTriforceMin.Content = "Минимальный элемент: " + ArrObj.UpTriforceMin().ToString();
            UpTriforceMax.Content = "Максимальный элемент: " + ArrObj.UpTriforceMax().ToString();

            DownTriforceSum.Content = "Сумма элементов: " + ArrObj.DownTriforceSum().ToString();
            DownTriforceMin.Content = "Минимальный элемент: " + ArrObj.DownTriforceMin().ToString();
            DownTriforceMax.Content = "Максимальный элемент: " + ArrObj.DownTriforceMax().ToString();

            LeftTriforceSum.Content = "Сумма элементов: " + ArrObj.LeftTriforceSum().ToString();
            LeftTriforceMin.Content = "Минимальный элемент: " + ArrObj.LeftTriforceMin().ToString();
            LeftTriforceMax.Content = "Максимальный элемент: " + ArrObj.LeftTriforceMax().ToString();
        }
    }
}
