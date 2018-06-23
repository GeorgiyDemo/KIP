using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;

namespace SimplexDemenchuk
{
    delegate void MainDell();

    public interface IDEMInterface
    {

        int MatrixFindRow(int FinalMainColumn);
        int MatrixFindColumn();
        bool FinalResultMethodFlag();
        double[,] CalculateViaSimplex(double[] result);

    }

    public class GetSimplexClass : IDEMInterface
    {
        double[,] BaseMatrix;
        private List<int> MainValueBase;
        private int m, n;

        public int MatrixFindRow(int FinalMainColumn)
        {
            int ReturnRowNumber = 0;
            for (int i = 0; i < m - 1; i++)
                if (BaseMatrix[i, FinalMainColumn] > 0)
                {

                    ReturnRowNumber = i;
                    break;
                }

            for (int i = ReturnRowNumber + 1; i < m - 1; i++)
            {
                if ((BaseMatrix[i, FinalMainColumn] > 0)
                    && ((BaseMatrix[i, 0] / BaseMatrix[i, FinalMainColumn])
                        < (BaseMatrix[ReturnRowNumber, 0] / BaseMatrix[ReturnRowNumber, FinalMainColumn]))
                   )
                    ReturnRowNumber = i;
            }

            return ReturnRowNumber;
        }

        public GetSimplexClass(double[,] TransferedData)
        {
            m = TransferedData.GetLength(0);
            n = TransferedData.GetLength(1);

            MainValueBase = new List<int>();
            BaseMatrix = new double[m, n + m - 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < BaseMatrix.GetLength(1); j++)
                {
                    if (j < n)
                    {
                        BaseMatrix[i, j] = TransferedData[i, j];
                    }

                    else
                    {
                        BaseMatrix[i, j] = 0;
                    }
                }

                if ((n + i) < BaseMatrix.GetLength(1))
                {
                    BaseMatrix[i, n + i] = 1;
                    MainValueBase.Add(n + i);
                }
            }

            n = BaseMatrix.GetLength(1);
        }

        public bool FinalResultMethodFlag()
        {
            for (int j = 1; j < n; j++)
                if (BaseMatrix[m - 1, j] < 0)
                    return false;
            return true;
        }

        public int MatrixFindColumn()
        {
            int MatrixColumn = 1;
            for (int value = 2; value < n; value++)
                if (BaseMatrix[m - 1, value] < BaseMatrix[m - 1, MatrixColumn])
                    MatrixColumn = value;
            return MatrixColumn;
        }

        public double[,] CalculateViaSimplex(double[] result)
        {
            int ThisColumn, ThisRow;
            while (!FinalResultMethodFlag())
            {
                ThisColumn = MatrixFindColumn();
                ThisRow = MatrixFindRow(ThisColumn);

                MainValueBase[ThisRow] = ThisColumn;
                double[,] MeowBaseMatrix = new double[m, n];

                for (int j = 0; j < n; j++)
                    MeowBaseMatrix[ThisRow, j] = BaseMatrix[ThisRow, j] / BaseMatrix[ThisRow, ThisColumn];

                for (int i = 0; i < m; i++)
                {
                    if (i == ThisRow)
                    {
                        continue;
                    }

                    for (int j = 0; j < n; j++)
                    {
                        MeowBaseMatrix[i, j] = BaseMatrix[i, j] - BaseMatrix[i, ThisColumn] * MeowBaseMatrix[ThisRow, j];
                    }
                }

                BaseMatrix = MeowBaseMatrix;
            }

            for (int i = 0; i < result.Length; i++)
            {
                int MainValueIndex = MainValueBase.IndexOf(i + 1);

                if (MainValueIndex != -1)
                {
                    result[i] = BaseMatrix[MainValueIndex, 0];
                }
                else
                {
                    result[i] = 0;
                }
            }
            return BaseMatrix;
        }
    }

    class Program
    {

        static void BaseNameGetter()
        {
            int Matrixn, Matrixm;

            Console.Write("Число переменных данной системы -> "); Matrixm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число ограничений данной системы -> "); Matrixn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*Ну, поехали*\n");

            double[,] InputedMatrix = new double[Matrixn + 1, Matrixm + 1];

            for (int i = 0; i < Matrixn; i++)
            {
                for (int j = 0; j < Matrixm; j++)
                {
                    Console.Write("Введите переменную " + (j + 1) + " ограничения №" + (i + 1) + ": ");
                    InputedMatrix[i, j + 1] = System.Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nВведите ограничение №" + (i + 1) + ": ");
                InputedMatrix[i, 0] = System.Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < Matrixm; j++)
            {
                Console.Write("Введите коэфф. " + (j + 1) + " функции: ");
                InputedMatrix[Matrixn, j + 1] = Convert.ToInt32(Console.ReadLine());
            }

            InputedMatrix[Matrixn, 0] = 0;

            double[] FinalAnswerArray = new double[Matrixm];

            Console.WriteLine("\nВвод (в реверсе):");
            for (int i = 0; i < InputedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < InputedMatrix.GetLength(1); j++)
                {
                    Console.Write("{0:F1}\t", InputedMatrix[i, j]);
                }
                Console.WriteLine();
            }

            GoodOutputMatrix(InputedMatrix, Matrixn, Matrixm);

            double[,] BaseMatrix =
                new GetSimplexClass(InputedMatrix).CalculateViaSimplex(FinalAnswerArray);
            Console.WriteLine("\nРешение (в реверсе):");
            for (int i = 0; i < BaseMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < BaseMatrix.GetLength(1); j++)
                    Console.Write("{0:F1}\t", BaseMatrix[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("\nОтветы:");
            for (int i = 0; i < Matrixm; i++)
                Console.WriteLine("X[" + (i + 1) + "] = " + FinalAnswerArray[i]);
        }

        static void GoodOutputMatrix(double[,] MatrixFather, int MatrixN, int MatrixM)
        {
            try
            {
                Console.WriteLine("Ввод:");

                int firstnumber = 1;
                int secondnumber;
                int n, m;
                double ch;
                double[,] FormatedMatrix = new double[MatrixN + 1, MatrixM + 1];


                ////////?????????/////////
                if (MatrixM == MatrixN)
                {
                    m = FormatedMatrix.GetLength(0);
                    n = FormatedMatrix.GetLength(1);
                    secondnumber = MatrixFather.GetLength(0);
                }
                else
                {
                    m = FormatedMatrix.GetLength(0) - 1;
                    n = FormatedMatrix.GetLength(1) + 1;
                    secondnumber = MatrixFather.GetLength(0) - 1;
                }

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        FormatedMatrix[i, j] = MatrixFather[i, j];

                for (int i = 0; i < n; i++)
                {
                    ch = FormatedMatrix[i, firstnumber - 1];
                    FormatedMatrix[i, firstnumber - 1] = FormatedMatrix[i, secondnumber - 1];
                    FormatedMatrix[i, secondnumber - 1] = ch;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write("{0:F1}\t", FormatedMatrix[i, j]);
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Не удалось построить матрицу без реверса!\n Попозже надо разобраться с индексами..");
            }
        }

        static void Main(string[] args)
        {
            MainDell dell_obj = BaseNameGetter;
            dell_obj();
        }
    }
}
