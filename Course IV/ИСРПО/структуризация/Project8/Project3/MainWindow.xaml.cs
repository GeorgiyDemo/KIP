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

namespace Project3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] ComboboxArr = new string[] { "Сфера", "Конус", "Усеченный конус", "Цилиндр" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            for(int i=0;i<ComboboxArr.Length;i++)
            MaincomboBox.Items.Add(ComboboxArr[i]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int BufIndex = MaincomboBox.SelectedIndex;
            switch (BufIndex)
            {
                case 0:
                    SpheraWindow SpheraWindow_obj = new SpheraWindow();
                    SpheraWindow_obj.Show();
                    break;
                case 1:
                    ConusWindow ConusWindow_obj = new ConusWindow();
                    ConusWindow_obj.Show();
                    break;
                case 2:
                    ShortConusWindow ShortConusWindow_obj = new ShortConusWindow();
                    ShortConusWindow_obj.Show();
                    break;
                case 3:
                    СylinderWindow CylindexWindow_obj = new СylinderWindow();
                    CylindexWindow_obj.Show();
                    break;
            }
        }
    }
}
