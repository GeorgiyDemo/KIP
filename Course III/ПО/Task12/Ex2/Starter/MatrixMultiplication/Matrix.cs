using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MatrixMultiplication
{
    /// <summary>
    /// Static class to perform a variety of matrix manipulations
    /// </summary>
    static class Matrix
    {
        /// <summary>
        /// Multiply two matrices together
        /// The number of columns in the first matrix must be the same as the number of rows in the second matrix
        /// </summary>
        /// <param name="matrix1">First matrix</param>
        /// <param name="matrix2">Second matrix</param>
        /// <returns>Product of matrix multiplication</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the matrices have incompatible dimensions or contain negative entries</exception>
        public static double[,] MatrixMultiply(double[,] matrix1, double[,] matrix2)
        {
            // TODO Evaluate input matrices for compatibility
            // Check the matrices are compatible 
            try
            {
                if (matrix1.Length != matrix2.Length)
                    throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число строк и столбцов должно совпадать");
            }

            try
            {
                if (matrix1.Length != matrix2.Length)
                    throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число строк и столбцов должно совпадать");
            }

            int m1columns_m2rows = matrix1.GetLength(0);
            int m1rows = matrix1.GetLength(1);
            int m2columns = matrix2.GetLength(0);
            double[,] result = new double[m2columns, m1rows];
            try
            {
                for (int row = 0; row < m1rows; row++)
                {
                    for (int column = 0; column < m2columns; column++)
                    {
                        double accumulator = 0;
                        for (int cell = 0; cell < m1columns_m2rows; cell++)
                        {
                            if (matrix1[column, cell] < 0)
                            {
                                throw new ArgumentException(string.Format(" Matrix1 содержит неправильное значение в ячейке[{0}, {1}].", column + 1, cell + 1));
                            }
                            if (matrix2[column, cell] < 0)
                            {
                                throw new ArgumentException(string.Format(" Matrix2 содержит неправильное значение в ячейке[{0}, {1}].", column + 1, cell + 1));
                            }
                            accumulator += matrix1[cell, row] * matrix2[column, cell];
                        }
                        result[column, row] = accumulator;
                    }
                }

            }
            catch (ArgumentException ex)
            { MessageBox.Show(ex.Message); }
            return result;
        }
    }
}