using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demenchuk
{
    public partial class MainWindow : Window
    {
        public static bool ExitBoolFlag = false;
        protected void AllMeowMatrixSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            InputMeowMatrixD.Children.Clear();
            InputMeowMatrixD.ColumnDefinitions.Clear();
            InputMeowMatrixD.RowDefinitions.Clear();
            int MatrixAllSizeContent = 0;
            MatrixAllSizeContent = AllMeowMatrixSize.SelectedIndex;

            if (MatrixAllSizeContent > 0)
            {
                if (!ExitBoolFlag)
                {
                    ExitBoolFlag = true;
                    AllMeowMatrixSize_SelectionChanged(sender, e);
                }

                StartMeowVershina.Items.Clear();
                EndMeowVershina.Items.Clear();

                for (int meow = 1; meow <= MatrixAllSizeContent; meow++)
                {
                    StartMeowVershina.Items.Add(new Item(Convert.ToString(meow), meow));
                    EndMeowVershina.Items.Add(new Item(Convert.ToString(meow), meow));
                }

                InputMeowMatrixForSetup(InputMeowMatrixD, MatrixAllSizeContent);
            }
        }
        protected void MeowResultButton_Click(object sender, RoutedEventArgs e)
        {
            int ExitCounterStop = 0;
            int ThisMatrixColumn = InputMeowMatrixD.ColumnDefinitions.Count;
            int ThisMatrixRow = InputMeowMatrixD.RowDefinitions.Count;
            double[,] RebroArray = new double[ThisMatrixColumn, ThisMatrixRow];

            OutputResultForm.TextAlignment = TextAlignment.Left;
            //Смежность 
            for (int Smez = 0; Smez < InputMeowMatrixD.Children.Count; Smez++)
            {
                TextBox SmeznostTextBox = (TextBox)InputMeowMatrixD.Children[Smez];
                int SmeznostMatrixRow = Grid.GetRow(SmeznostTextBox);
                int SmeznostMatrixColumn = Grid.GetColumn(SmeznostTextBox);

                if (!double.TryParse(SmeznostTextBox.Text, out RebroArray[SmeznostMatrixColumn, SmeznostMatrixRow]))
                {
                    MessageBox.Show("Проверь ввод, что-то явно не так");
                    return;
                }

            }

            for (int i = 0; i < ThisMatrixColumn; i++)
                for (int j = 0; j < ThisMatrixRow; j++)

                    if (RebroArray[i, j] != RebroArray[j, i])
                    {
                        MessageBox.Show("Матрица смежности по-хорошему быть зеркальной, посмотри ввод");
                        return;
                    }

            if ((StartMeowVershina.SelectedIndex == -1) || (EndMeowVershina.SelectedIndex == -1))
            {
                MessageBox.Show("Поспешишь - людей насмешишь\nЗабыл ввести начало и/или конец пути");
                return;
            }

            double[] MeowMetkaArray = new double[ThisMatrixColumn];
            bool[] MeowMetkaArrayOtherwise = new bool[ThisMatrixColumn];

            bool StrangeMeowValue = false;
            int StartKotVershina = Convert.ToInt32(StartMeowVershina.SelectedItem.ToString()) - 1;
            int CurrentVershinaIndex = StartKotVershina;
            for (int i = 0; i < ThisMatrixRow; i++)
            {
                MeowMetkaArray[i] = -1;
                MeowMetkaArrayOtherwise[i] = false;
            }

            MeowMetkaArray[StartKotVershina] = 0;
            MeowMetkaArrayOtherwise[StartKotVershina] = true;
            do
            {

                for (int Puti = 0; Puti < ThisMatrixRow; Puti++)
                {
                    if ((RebroArray[CurrentVershinaIndex, Puti] != 0)) // есть путь в вершину из текущей рассматриваемой
                        if ((MeowMetkaArray[Puti] > RebroArray[CurrentVershinaIndex, Puti] + MeowMetkaArray[CurrentVershinaIndex]) || (MeowMetkaArray[Puti] == -1)) //метка меньше или не записана
                        {
                            MeowMetkaArray[Puti] = RebroArray[CurrentVershinaIndex, Puti] + MeowMetkaArray[CurrentVershinaIndex]; //метка = путь из рассматриваемой вершины + метка этой вершины
                        }

                }

                for (int i = 0; i < ThisMatrixRow; i++)
                {
                    if ((MeowMetkaArray[i] != -1) && (!MeowMetkaArrayOtherwise[i]))
                    {
                        CurrentVershinaIndex = i;
                        break;
                    }

                }

                for (int MinMetka = 0; MinMetka < ThisMatrixRow; MinMetka++)
                    if ((MeowMetkaArray[MinMetka] != -1) && (MeowMetkaArray[MinMetka] < MeowMetkaArray[CurrentVershinaIndex]) && (!MeowMetkaArrayOtherwise[MinMetka]))
                        CurrentVershinaIndex = MinMetka;

                MeowMetkaArrayOtherwise[CurrentVershinaIndex] = true;
                if (CurrentVershinaIndex == Convert.ToInt32(EndMeowVershina.SelectedItem.ToString()) - 1) //Если дошли до конца, завершаем работу цикла
                    StrangeMeowValue = true;

                ExitCounterStop++;

                if (ExitCounterStop > ThisMatrixRow + 1)
                {
                    MessageBox.Show("Между выбранными вершинами пути не существует, мы зациклились");
                    return;
                }
            } while (!StrangeMeowValue);

            OutputResultForm.Text = "Мин. расстояние = " + MeowMetkaArray[CurrentVershinaIndex].ToString() + "\n";

            StringBuilder ResultStringBuilder = new StringBuilder();
            do
            {
                ResultStringBuilder.Insert(0, " - " + Convert.ToString(CurrentVershinaIndex + 1));
                for (int i = 0; i < ThisMatrixRow; i++)
                {
                    if (i != CurrentVershinaIndex)
                        if ((MeowMetkaArray[CurrentVershinaIndex] == MeowMetkaArray[i] + RebroArray[CurrentVershinaIndex, i]) && (RebroArray[CurrentVershinaIndex, i] != 0) && (MeowMetkaArrayOtherwise[i] == true))
                        {
                            CurrentVershinaIndex = i;
                            break;
                        }
                }

            }
            while (CurrentVershinaIndex != StartKotVershina);
            ResultStringBuilder.Insert(0, Convert.ToString(StartKotVershina + 1));
            OutputResultForm.Text += "Путь: " + ResultStringBuilder.ToString();
        }
        protected void MatrixSize_TouchEnter(object sender, TouchEventArgs e)
        {
            AllMeowMatrixSize.Text = "";
        }
        static void InputMeowMatrixForSetup(Grid ThisMatrix, int MatrixSize)
        {
            ThisMatrix.Children.Clear();
            ThisMatrix.ColumnDefinitions.Clear();
            ThisMatrix.RowDefinitions.Clear();

            for (int i = 0; i < MatrixSize; i++)
            {
                ThisMatrix.ColumnDefinitions.Add(
                    new ColumnDefinition()
                    {
                        Width = new GridLength(1, GridUnitType.Star),
                    }
                 );

                ThisMatrix.RowDefinitions.Add(
                    new RowDefinition()
                    {
                        Height = new GridLength(1, GridUnitType.Star),
                    }
                );

                for (int j = 0; j < MatrixSize; j++)
                {
                  
                    TextBox MeowTextBox = new TextBox();
                    MeowTextBox.Width = 35;
                    if (j == i)
                        MeowTextBox.Text = "0";

                    MeowTextBox.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                    MeowTextBox.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                    MeowTextBox.SetValue(Grid.RowProperty, j);
                    MeowTextBox.SetValue(Grid.ColumnProperty, i);
                    MeowTextBox.TextAlignment = TextAlignment.Center;

                    ThisMatrix.Children.Add(MeowTextBox);

                }
      
            }
          
        }
        protected class Item
        {
            public string MatrixElementName;
            public int MatrixElementContentValue;

            public Item(string n, int v)
            {
                MatrixElementName = n; MatrixElementContentValue = v;
            }

            public override string ToString()
            {
                return MatrixElementName;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
