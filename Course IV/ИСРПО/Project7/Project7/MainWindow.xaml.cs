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
            ArrayClass obj = new ArrayClass();
            MainDataGrid.ItemsSource = obj.DataGridInput();

        }
    }
}
