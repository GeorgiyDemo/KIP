using System;
using System.Data;
using System.Windows;

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

            int min = MainArray[0, 0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i == j) && (MainArray[i, j] < min))
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

        public static int AlterDiagonalSum()
        {

            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) == (MainArray.GetLength(1) - 1))
                        sum += MainArray[i, j];
            return sum;
        }

        public static int AlterDiagonalMin()
        {

            int min = MainArray[9,0];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) == (MainArray.GetLength(1) - 1) && (MainArray[i, j] < min))
                        min = MainArray[i, j];
            return min;
        }

        public static int AlterDiagonalMax()
        {

            int max = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) == (MainArray.GetLength(1) - 1) && (MainArray[i, j] > max))
                        max = MainArray[i, j];
            return max;
        }

        public static int UpTriforceMin()
        {
            int min = MainArray[0, 1];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) < (MainArray.GetLength(1) - 1) && (i > j) && (MainArray[i, j] < min))
                        min = MainArray[i, j];
            return min;
        }

        public static int UpTriforceMax()
        {
            int max = MainArray[0, 1];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) < (MainArray.GetLength(1) - 1) && (i > j) && (MainArray[i, j] > max))
                        max = MainArray[i, j];
            return max;
        }

        public static int UpTriforceSum()
        {

            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) < (MainArray.GetLength(1) - 1) && (i > j))
                        sum += MainArray[i, j];
            return sum;
        }

        public static int DownTriforceMin()
        {
            int min = MainArray[0, 1];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) > (MainArray.GetLength(1) - 1) && (i < j) && (MainArray[i, j] < min))
                        min = MainArray[i, j];
            return min;
        }

        public static int DownTriforceMax()
        {
            int max = MainArray[0, 1];
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) > (MainArray.GetLength(1) - 1) && (i < j) && (MainArray[i, j] > max))
                        max = MainArray[i, j];
            return max;
        }

        public static int DownTriforceSum()
        {

            int sum = 0;
            for (int i = 0; i < MainArray.GetLength(0); i++)
                for (int j = 0; j < MainArray.GetLength(1); j++)
                    if ((i + j) > (MainArray.GetLength(1) - 1) && (i < j))
                        sum += MainArray[i, j];
            return sum;
        }

    }
}