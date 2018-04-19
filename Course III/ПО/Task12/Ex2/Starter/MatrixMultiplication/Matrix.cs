using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            
            // Get the dimensions
            int m1columns_m2rows = matrix1.GetLength(0);
            int m1rows = matrix1.GetLength(1);
            int m2columns = matrix2.GetLength(0);

            // Create a suitable array to hold the result of the multiplication
            double[,] result = new double[m2columns, m1rows];

            // Calculate the value for each cell in the result matrix
            for (int row = 0; row < m1rows; row++)
            {
                for (int column = 0; column < m2columns; column++)
                {
                    // Initialize the value for the result cell
                    double accumulator = 0;
                    
                    // Iterate over the row in the source matrix multiplying by the value in the column in the second matrix, add to the accumulator
                    for (int cell = 0; cell < m1columns_m2rows; cell++)
                    {
                        // TODO Evaluate matrix data points for invalid data
                        // Throw exceptions if either matrix contains a negative entry
                        accumulator += matrix1[cell, row] * matrix2[column, cell];
                    }
                    result[column, row] = accumulator;
                }
            }
            return result;
        }
    }
}
