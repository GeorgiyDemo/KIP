using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Многомерные массивы
            */
            int[,] data2 = new int[4, 2] { { 1, 2 }, { 5, 8 }, { 7, 9 }, { 8, 10 } };
            int[,,] data3 = new int [5, 2, 3];
            int[,] data4 = { { 1, 2 }, { 5, 9 }, { 11, 12 } };
            int[] data = { 1, 2, 4, 5, 6 };

            /*
             Ступенчатые массивы
             Type [][] JaggedArray = new Type[size][];
            */

            int[][] dd = new int[3][];
            int [][] JaggedArray = new int[4][];
            for (int i = 0; i < dd.Length; i++)
                dd[i] = new int[i + 1];

            for (int i = 0; i < dd.Length; i++)
                for (int j = 0; j < dd[i].Length; j++)
                    Console.Write(dd[i][j]);

            int len = dd.Length + dd[1].Length + dd[2].Length;
            Console.WriteLine("\n"+len);

            /*
             Отличия for и foreach
            */

            int[] oldnumbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < oldnumbers.Length;i++)
            {
                int number = oldnumbers[i];

            }

            foreach (int number in oldnumbers){
                
            }

            /*
             Краткая форма if
             Type result = [condition] ? [true expression] : [false expression]
            */

            string carColor = "green";
            string response = (carColor == "red") ? "You have a red car" : "You do not have a red car";

        }
    }
}
