using System;
using System.Collections.Generic;
using System.Dynamic;
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

namespace Project2
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

        static public double Checker(double x, double a)
        {
            if (x < 0)
                return x * x * Math.Sin(x + a);
            else if (x >= 0)
                return x / Math.Log(x + a);
            return 0;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            double a = System.Convert.ToDouble(InputTextbox.Text);

            string[] labels = new string[] { "Значение X", "Значение Y" };

            foreach (string label in labels)
            {
                DataGridTextColumn column = new DataGridTextColumn();
                column.Header = label;
                column.Binding = new Binding(label.Replace(' ', '_'));

                MainDataGrid.Columns.Add(column);
            }

            for (int i = -20; i < 21; i++)
                if ((i >= -20) && (i <= 20))
                {

                    string[] values = new string[] { System.Convert.ToString(i), Convert.ToString(Math.Round(Checker(i, a), 4)) };

                    dynamic row = new ExpandoObject();

                    for (int ii = 0; ii < labels.Length; ii++)
                        ((IDictionary<String, Object>)row)[labels[ii].Replace(' ', '_')] = values[ii];

                    MainDataGrid.Items.Add(row);
                }
        }
            
        private void MainDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
