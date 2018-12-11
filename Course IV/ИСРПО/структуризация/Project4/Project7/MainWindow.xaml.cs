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

        //Основная

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
            MainDiagonalMax.Content = " Максимальный элемент: " + ArrayClass.MainDiagonalMax().ToString();
        }

        //Побочная

        private void SecondaryDiagonalSum_Initialized(object sender, EventArgs e)
        {
            SecondaryDiagonalSum.Content = "Сумма элементов: " + ArrayClass.SecondaryDiagonalSum().ToString();
        }

        private void SecondaryDiagonaMin_Initialized(object sender, EventArgs e)
        {
            SecondaryDiagonaMin.Content = "Минимальный элемент: " + ArrayClass.SecondaryDiagonalMin().ToString();
        }

        private void SecondaryDiagonalMax_Initialized(object sender, EventArgs e)
        {
            SecondaryDiagonalMax.Content = " Максимальный элемент: " + ArrayClass.SecondaryDiagonalMax().ToString();
        }

        //Левый

        private void LeftTriangleSum_Initialized(object sender, EventArgs e)
        {
            LeftTriangleSum.Content = "Сумма элементов: " + ArrayClass.LeftTriangleSum().ToString();
        }

        private void LeftTriangleMin_Initialized(object sender, EventArgs e)
        {
            LeftTriangleMin.Content = "Минимальный элемент: " + ArrayClass.LeftTriangleMin().ToString();
        }

        private void LeftTriangleMax_Initialized(object sender, EventArgs e)
        {
            LeftTriangleMax.Content = " Максимальный элемент: " + ArrayClass.LeftTriangleMax().ToString();
        }

        //Правый

        private void RightTriangleSum_Initialized(object sender, EventArgs e)
        {
            RightTriangleSum.Content = "Сумма элементов: " + ArrayClass.RightTriangleSum().ToString();
        }

        private void RightTriangleMin_Initialized(object sender, EventArgs e)
        {
            RightTriangleMin.Content = "Минимальный элемент: " + ArrayClass.RightTriangleMin().ToString();
        }

        private void RightTriangleMax_Initialized(object sender, EventArgs e)
        {
            RightTriangleMax.Content = " Максимальный элемент: " + ArrayClass.RightTriangleMax().ToString();
        }

        //Верхний

        private void UpTriangleSum_Initialized(object sender, EventArgs e)
        {
            UpTriangleSum.Content = "Сумма элементов: " + ArrayClass.UpTriangleSum().ToString();
        }

        private void UpTriangleMin_Initialized(object sender, EventArgs e)
        {
            UpTriangleMin.Content = "Минимальный элемент: " + ArrayClass.UpTriangleMin().ToString();
        }

        private void UpTriangleMax_Initialized(object sender, EventArgs e)
        {
            UpTriangleMax.Content = " Максимальный элемент: " + ArrayClass.UpTriangleMax().ToString();
        }

        //Нижний

        private void DownTriangleSum_Initialized(object sender, EventArgs e)
        {
            DownTriangleSum.Content = "Сумма элементов: " + ArrayClass.DownTriangleSum().ToString();
        }

        private void DownTriangleMin_Initialized(object sender, EventArgs e)
        {
            DownTriangleMin.Content = "Минимальный элемент: " + ArrayClass.DownTriangleMin().ToString();
        }

        private void DownTriangleMax_Initialized(object sender, EventArgs e)
        {
            DownTriangleMax.Content = " Максимальный элемент: " + ArrayClass.DownTriangleMax().ToString();
        }

        private void Button_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainDataGrid.ItemsSource = null;
                MainDataGrid.ItemsSource = ArrayClass.DataGridInput(true).DefaultView;
                MainDiagonalSum.Content = "Сумма элементов: " + ArrayClass.MainDiagonalSum().ToString();
                MainDiagonaMin.Content = "Минимальный элемент: " + ArrayClass.MainDiagonalMin().ToString();
                MainDiagonalMax.Content = " Максимальный элемент: " + ArrayClass.MainDiagonalMax().ToString();
                SecondaryDiagonalSum.Content = "Сумма элементов: " + ArrayClass.SecondaryDiagonalSum().ToString();
                SecondaryDiagonaMin.Content = "Минимальный элемент: " + ArrayClass.SecondaryDiagonalMin().ToString();
                SecondaryDiagonalMax.Content = " Максимальный элемент: " + ArrayClass.SecondaryDiagonalMax().ToString();
                LeftTriangleSum.Content = "Сумма элементов: " + ArrayClass.LeftTriangleSum().ToString();
                LeftTriangleMin.Content = "Минимальный элемент: " + ArrayClass.LeftTriangleMin().ToString();
                LeftTriangleMax.Content = " Максимальный элемент: " + ArrayClass.LeftTriangleMax().ToString();
                RightTriangleSum.Content = "Сумма элементов: " + ArrayClass.RightTriangleSum().ToString();
                RightTriangleMin.Content = "Минимальный элемент: " + ArrayClass.RightTriangleMin().ToString();
                RightTriangleMax.Content = " Максимальный элемент: " + ArrayClass.RightTriangleMax().ToString();
                UpTriangleSum.Content = "Сумма элементов: " + ArrayClass.UpTriangleSum().ToString();
                UpTriangleMin.Content = "Минимальный элемент: " + ArrayClass.UpTriangleMin().ToString();
                UpTriangleMax.Content = " Максимальный элемент: " + ArrayClass.UpTriangleMax().ToString();
                DownTriangleSum.Content = "Сумма элементов: " + ArrayClass.DownTriangleSum().ToString();
                DownTriangleMin.Content = "Минимальный элемент: " + ArrayClass.DownTriangleMin().ToString();
                DownTriangleMax.Content = " Максимальный элемент: " + ArrayClass.DownTriangleMax().ToString();
            }
            catch (Exception)
            {

            }
        }

    }
}
