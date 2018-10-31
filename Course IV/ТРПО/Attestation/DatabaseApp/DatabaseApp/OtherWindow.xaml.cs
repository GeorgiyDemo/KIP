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
using System.Windows.Shapes;

namespace DatabaseApp
{
    /// <summary>
    /// Логика взаимодействия для OtherWindow.xaml
    /// </summary>
    public partial class OtherWindow : Window
    {
        public OtherWindow()
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = StoreArrayClass.DataGridInput().DefaultView;
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
