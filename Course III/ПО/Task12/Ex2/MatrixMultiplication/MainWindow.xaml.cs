using System;
using System.Windows;
using System.Windows.Controls;

namespace MatrixMultiplication
{
    public partial class MainWindow : Window
    {

        double[,] matrix1;
        double[,] matrix2;
        double[,] result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MatrixDimensions_Changed(object sender, SelectionChangedEventArgs e)
        {
            int m1rows = 1;
            int m1columns_m2rows = 1;
            int m2columns = 1;
            if (matrix1width != null) m1columns_m2rows = matrix1width.SelectedIndex + 1;
            if (matrix1height != null) m1rows = matrix1height.SelectedIndex + 1;
            if (matrix2width != null) m2columns = matrix2width.SelectedIndex + 1;
            matrix1 = new double[m1columns_m2rows, m1rows];
            matrix2 = new double[m2columns, m1columns_m2rows];
            result = new double[m2columns, m1rows];
            InitializeGrid(grid1, matrix1);
            InitializeGrid(grid2, matrix2);
            InitializeGrid(grid3, result);
        }

        private void InitializeGrid(Grid grid, double[,] matrix)
        {
            if (grid != null)
            {
                grid.Children.Clear();
                grid.ColumnDefinitions.Clear();
                grid.RowDefinitions.Clear();
                int columns = matrix.GetLength(0);
                int rows = matrix.GetLength(1);

                for (int x = 0; x < columns; x++)
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star), });

                for (int y = 0; y < rows; y++)
                    grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star), });

                for (int x = 0; x < columns; x++)
                    for (int y = 0; y < rows; y++)
                    {
                        double cell = (double)matrix[x, y];
                        TextBox t = new TextBox();
                        t.Text = cell.ToString();
                        t.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        t.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        t.SetValue(Grid.RowProperty, y);
                        t.SetValue(Grid.ColumnProperty, x);
                        grid.Children.Add(t);
                    }
            }
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            GetValuesFromGrid(grid1, matrix1);
            GetValuesFromGrid(grid2, matrix2);

            try
            {
                result = Matrix.MatrixMultiply(matrix1, matrix2);
                throw new ArgumentException();
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeGrid(grid3, result);
        }

        private void GetValuesFromGrid(Grid grid, double[,] matrix)
        {
            int columns = grid.ColumnDefinitions.Count;
            int rows = grid.RowDefinitions.Count;
            if (columns != matrix.GetLength(0)) throw new ArgumentException("Grid and matrix have different number of columns");
            if (rows != matrix.GetLength(1)) throw new ArgumentException("Grid and matrix have different number of rows");
            for (int c = 0; c < grid.Children.Count; c++)
            {
                TextBox t = (TextBox)grid.Children[c];
                int row = Grid.GetRow(t);
                int column = Grid.GetColumn(t);
                matrix[column, row] = double.Parse(t.Text);
            }
        }
    }
}