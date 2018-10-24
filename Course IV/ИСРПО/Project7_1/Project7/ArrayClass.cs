using System;
using System.Data;

namespace Project7
{
    static class ArrayClass
    {
        static int[,] MainArray;
        private static Random random = new Random();

        public static int[,] GetArray()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                 
            array[i, j] = random.Next(0, 100);
            return array;
        }


        public static DataTable DataGridInput(bool flag)
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


        public static int MainDiagonalSum()
        {

            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if (i == j)
                        sum += MainArray[i, j];
            return sum;
        }

        public static int MainDiagonalMin()
        {

            int min = MainArray[0,0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i == j) && (MainArray[i,j]< min))
                        min = MainArray[i, j];

            return min;
        }


        public static int MainDiagonalMax()
        {

            int max = MainArray[0, 0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i == j) && (MainArray[i, j] > max))
                        max = MainArray[i, j];

            return max;
        }

        public static int SecondaryDiagonalSum()
        {

            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if (i + j == 10-1)
                        sum += MainArray[i, j];
            return sum;
        }

        public static int SecondaryDiagonalMin()
        {

            int min = MainArray[9, 0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) == (10 - 1) && (MainArray[i, j] < min))
                        min = MainArray[i, j];

            return min;
        }

        public static int SecondaryDiagonalMax()
        {

            int max = MainArray[9, 0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) == (10 - 1) && (MainArray[i, j] > max))
                        max = MainArray[i, j];

            return max;
        }

        public static int LeftTriangleSum()
        {
            int sum = 0;
            for (int i = 1; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j <= i && j <= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        sum += MainArray[i, j];
                    }
                }
            }
            return sum;
        }

        public static int LeftTriangleMin()
        {
            int min = MainArray[1, 9];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (min > MainArray[i, j] && j <= i && j <= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        min = MainArray[i, j];
                    }
                }
            }
            return min;
        }

        public static int LeftTriangleMax()
        {
            int max = MainArray[1, 9];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (max < MainArray[i, j] && j<=i && j<=10-i-1 && i!=j && (i + j) != (10 - 1))
                    {
                        max = MainArray[i, j];
                    }
                }
            }
            return max;
        }

        public static int RightTriangleSum()
        {
            int sum = 0;
            for (int i = 1; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (j >= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        sum += MainArray[i, j];
                    }
                }
            }
            return sum;
        }

        public static int RightTriangleMin()
        {
            int min = MainArray[1, 0];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (min > MainArray[i, j] && j >= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        min = MainArray[i, j];
                    }
                }
            }
            return min;
        }

        public static int RightTriangleMax()
        {
            int max = MainArray[1, 0];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (max < MainArray[i, j] && j >= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        max = MainArray[i, j];
                    }
                }
            }
            return max;
        }

        public static int UpTriangleSum()
        {
            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (j >= i && j <= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        sum += MainArray[i, j];
                    }
                }
            }
            return sum;
        }

        public static int UpTriangleMin()
        {
            int min = MainArray[0, 1];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (min > MainArray[i, j] && j >= i && j <= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        min = MainArray[i, j];
                    }
                }
            }
            return min;
        }

        public static int UpTriangleMax()
        {
            int max = MainArray[0, 1];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (max < MainArray[i, j] && j >= i && j <= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        max = MainArray[i, j];
                    }
                }
            }
            return max;
        }

        public static int DownTriangleSum()
        {
            int sum = 0;

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (j <= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        sum += MainArray[i, j];
                    }
                }
            }
            return sum;
        }

        public static int DownTriangleMin()
        {
            int min = MainArray[9, 1];
            
            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (min > MainArray[i, j] && j <= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        min = MainArray[i, j];
                    }
                }
            }
            return min;
        }

        public static int DownTriangleMax()
        {
            int max = MainArray[9, 1];

            for (int i = 0; i < MainArray.GetLength(0); i++)
            {
                for (int j = 0; j < MainArray.GetLength(1); j++)
                {
                    if (max < MainArray[i, j] && j <= i && j >= 10 - i - 1 && i != j && (i + j) != (10 - 1))
                    {
                        max = MainArray[i, j];
                    }
                }
            }
            return max;
        }
    }

}
