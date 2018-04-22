using System;
using System.Windows;

namespace MatrixMultiplication
{
    static class Matrix
    {
       public static double[,] MatrixMultiply(double[,] matrix1, double[,] matrix2)
        {
            try
            {
                if (matrix1.GetLength(0) != matrix2.GetLength(1))
                    throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число столбцов матрицы №1 и число строк матрицы №2 должно совпадать!");
            }

            int m1columns_m2rows = matrix1.GetLength(0);
            int m1rows = matrix1.GetLength(1);
            int m2columns = matrix2.GetLength(0);
            double[,] result = new double[m2columns, m1rows];

            try
            {
                for (int row = 0; row < m1rows; row++)
                    for (int column = 0; column < m2columns; column++)
                    {
                        double accumulator = 0;
                        for (int cell = 0; cell < m1columns_m2rows; cell++)
                        {

                            if (matrix1[column, cell] < 0)
                                throw new ArgumentException(string.Format(" Matrix1 содержит некорректное значение в ячейке[{0}, {1}].", column + 1, cell + 1));
                            if (matrix2[column, cell] < 0)
                                throw new ArgumentException(string.Format(" Matrix2 содержит некорректное значение в ячейке[{0}, {1}].", column + 1, cell + 1));

                            accumulator += matrix1[cell, row] * matrix2[column, cell];
                        }
                        result[column, row] = accumulator;
                    }

            }
            catch (ArgumentException ex){
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}