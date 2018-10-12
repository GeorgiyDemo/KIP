using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace Project3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        string[,] MainArray;
        private static Random random = new Random();

        public string[,] GetArray()
        {
            string[,] array = new string[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    array[i, j] = RandomString(1);
             return array;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }

        public DataTable DataGridInput(bool flag)
        {
            MainArray = flag ? GetArray() : MainArray;
            var rows = MainArray.GetLength(0);
            var columns = MainArray.GetLength(1);

            var t = new DataTable();
            for (var c = 0; c < columns; c++)
                t.Columns.Add(new DataColumn(c.ToString()));

            for (var r = 0; r < rows; r++)
            {
                var newRow = t.NewRow();
                for (var c = 0; c < columns; c++)
                    newRow[c] = MainArray[r, c];
                t.Rows.Add(newRow);
            }

            return t;
        }

        public MainWindow()
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = DataGridInput(true).DefaultView;
        }

        private void FirstToSecondButton_Click(object sender, RoutedEventArgs e)
        {
            MainDataGrid.ItemsSource = null;
    
            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++) {

                    try
                    {
                        MainTextbox.Text += MainArray[i, j].ToString();
                    }
                    catch (Exception)
                    {
                        MainArray[i, j] = "";
                        MainTextbox.Text += MainArray[i, j].ToString();
                    }
                }
                MainTextbox.Text += "\n";
            }

            for (int i = 0; i < MainArray.GetLength(1); i++)
            {
                for (int j = 0; j < MainArray.GetLength(0); j++)
                {
                    try
                    {
                        VerticalTextBox.Text += MainArray[j, i].ToString();
                    }
                    catch (Exception)
                    {
                        MainArray[j, i] = "";
                        MainTextbox.Text += MainArray[j, i].ToString();
                    }
                }
                VerticalTextBox.Text += "\n";
            }
        }

        private void SecondToFirstButton_Click(object sender, RoutedEventArgs e)
        {
       
            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                string check = MainTextbox.Text.Split('\n')[i];
                    if (check.Length < MainArray.GetLength(0))
                    {
                        int difflength = Math.Abs(MainArray.GetLength(0) - check.Length);
                        int counter = MainArray.GetLength(0)-1;

                        while (counter > MainArray.GetLength(0)-1-difflength)
                        {
                            MainArray[i, counter] = "";
                            counter--;
                        }
                    }

                if (check.Length > MainArray.GetLength(0))
                {

                    MainArray = ResizeArray(MainArray, MainArray.GetLength(0), MainArray.GetLength(1)+(check.Length-MainArray.GetLength(0)));
                }

                for (int j = 0; j < check.Length; j++)
                {

                    if (check.Length> MainArray.GetLength(0))
                        MainArray[i, j] = check[j].ToString();

                }


            }

            MainTextbox.Text = "";
            VerticalTextBox.Text = "";
            MainDataGrid.ItemsSource = DataGridInput(false).DefaultView;
        }
    }
}
