using System;

namespace Test
{
    class Program
    {
        //Стат функция c неопределенным набором параметров, см строчку 85
        static int Add(params int[] data)
        {
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i];
            return sum;
        }

        /*
         Передача именованных параметров
         Вызов метода с использованием именованых параметров
        */
        static void MyMethod(int intData, float floatData=101.1F,int moreIntData =99){
            
        }

        /*
            Пример передачи параметров по значению
        */


        /*
         Тут все основное
         */
        static void Main(string[] args)
        {

            /*
             Многомерные массивы
            */
            int[,] data2 = new int[4, 2] { { 1, 2 }, { 5, 8 }, { 7, 9 }, { 8, 10 } };
            int[,,] data3 = new int[5, 2, 3];
            int[,] data4 = { { 1, 2 }, { 5, 9 }, { 11, 12 } };
            int[] data = { 1, 2, 4, 5, 6 };

            /*
             Ступенчатые массивы
             Type [][] JaggedArray = new Type[size][];
            */

            int[][] dd = new int[3][];
            int[][] JaggedArray = new int[4][];
            for (int i = 0; i < dd.Length; i++)
                dd[i] = new int[i + 1];

            for (int i = 0; i < dd.Length; i++)
                for (int j = 0; j < dd[i].Length; j++)
                    Console.Write(dd[i][j]);

            int len = dd.Length + dd[1].Length + dd[2].Length;
            Console.WriteLine("\n" + len);

            /*
             Отличия for и foreach
            */

            int[] oldnumbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < oldnumbers.Length; i++)
            {
                int number = oldnumbers[i];

            }

            foreach (int number in oldnumbers)
            {

            }

            /*
             Краткая форма if
             Type result = [condition] ? [true expression] : [false expression]
            */

            string carColor = "green";
            string response = (carColor == "red") ? "You have a red car" : "You do not have a red car";

            /*
             Методы разделяются на обычные и статические
             */

            /*
             Обычный, count - объект
             */
            int count = 99;
            string strCount = count.ToString();

            /*Статический метод
             Вызов методов используется при помощи имени класса без инициализации объекта
            */
            string strCount1 = "99";
            count = Convert.ToInt32(strCount1);

            /*
             Используем params - возможность передачи произвольного числа параметров
             */

            int sum = Add(99, 2, 55, -26);
            Console.WriteLine(sum);


        }
    }
}
