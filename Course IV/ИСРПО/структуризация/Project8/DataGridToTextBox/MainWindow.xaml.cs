using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridToTextBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public bool NapravlRow = false;
        public bool NapravlColomn = false;
        public static int ColEnter =10;
        int[] razmStrColoum = new int[ColEnter];
        public static int rows = 10;
        public static int columns = 10;
        public static int realRows = 10;
        public int[] razmStr = new int[25];

        private void outData_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из программы", "Малкеров Геннадий", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }

        private void outData_Click_1(object sender, RoutedEventArgs e)
        {
            if (!NapravlColomn)
            {
                if (NapravlRow)
                {
                    int pos = 0;
                    int row = 0;
                    int[] PosEnter = new int[25];

                    for (int i = 0; i < 25; i++)
                    {
                        PosEnter[i] = -1;
                        razmStr[i] = -1;
                    }
                    string StringFromTXT = txt.Text;
                    for (int i = 0; i < StringFromTXT.Length; i++)
                    {
                        if (StringFromTXT[i] == '\n')
                        {
                            PosEnter[pos] = i;
                            pos++;
                            row++;
                        }
                    }
                    rows = row;

                    for (int i = 0; i < PosEnter.Length; i++)
                    {
                        if (i == 0)
                        {
                            razmStr[i] = PosEnter[i];
                        }
                        else
                        {
                            razmStr[i] = Math.Abs((PosEnter[i - 1] + 1) - PosEnter[i]);
                        }
                    }
                    string str = "";
                    for (int i = 0; i < razmStr.Length; i++)
                    {
                        if (razmStr[i] != -1)
                        {
                            str = str + razmStr[i].ToString() + "\n";
                        }
                    }
                    int max = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        if (max < razmStr[i])
                        {
                            max = razmStr[i];
                        }
                    }
                    columns = max;
                    realRows = max;
                    DataTable dt = new DataTable();
                    dt = new DataTable();
                    NapravlRow = true;
                    for (int i = 0; i < columns; i++)
                    {
                        dt.Columns.Add((i + 1).ToString());
                    }
                    int ss = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        string st = StringFromTXT.Substring(ss, razmStr[i] + 1);
                        ss = ss + razmStr[i] + 1;
                        st = st.Replace("\n", "");
                        var nr = dt.NewRow();
                        for (int j = 0; j < razmStr[i]; j++)
                        {

                            nr[j] = Convert.ToChar(st[j]);

                        }
                        dt.Rows.Add(nr);
                    }
                    txt.Text = "";
                    DataGrid.ItemsSource = dt.DefaultView;
                    NapravlRow = false;
                    outData.Content = "------->";
                }
                else
                {
                    string TextToTXT = "";
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            var ci = new DataGridCellInfo(DataGrid.Items[i], DataGrid.Columns[j]);
                            var content = ci.Column.GetCellContent(ci.Item) as TextBlock;

                            if (content != null)
                            {
                                TextToTXT = TextToTXT + content.Text + "";
                            }
                        }
                        TextToTXT = TextToTXT + "\n";
                    }
                    txt.Text = TextToTXT;
                    DataTable dt = new DataTable();
                    dt = new DataTable();
                    NapravlRow = true;
                    for (int i = 0; i < columns; i++)
                    {
                        dt.Columns.Add((i + 1).ToString());
                    }
                    DataGrid.ItemsSource = dt.DefaultView;
                    outData.Content = "<-------";
                }
            }
            else
            {
                MessageBox.Show("dataGrid пустой, его необходимо его заполнить", "Малкеров Геннадий");
            }

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refr();
        }
        public void Refr()
        {
            rows = 10;
            columns = 10;
            ColEnter = 10;
            DataTable dt = new DataTable();
            for (int i = 0; i < columns; i++)
            {
                razmStr[i] = 10;
                razmStrColoum[i]=10;
            }
            
            for (int i = 0; i < columns; i++)
            {
                dt.Columns.Add((i + 1).ToString());
            }

            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                var nr = dt.NewRow();
                for (int j = 0; j < columns; j++)
                {
                    nr[j] = (char)rand.Next(50, 93);
                }
                dt.Rows.Add(nr);
            }
            DataGrid.ItemsSource = dt.DefaultView;
        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите обновить", "Малкеров Геннадий", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                txt.Text = null;
                txtVertical.Text = null;
                Refr();
                NapravlRow = false;
                NapravlColomn = false;
                outDataVertical.Content = "------->";
                outData.Content = "------->";
            }
        }

        private void AddRow_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите добавить строку в TextBox?", "Малкеров Геннадий", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                txt.Text = txt.Text + "\n";
            }
        }

        private void outDataVertical_Click(object sender, RoutedEventArgs e)
        {
            if (!NapravlRow)
            {
                if (NapravlColomn)
                {
                    NapravlColomn = false;
                    outDataVertical.Content = "------->";
                    string StringFromTXT = txtVertical.Text;
                    int ColEnter = 0;
                    for (int i = 0; i < StringFromTXT.Length; i++)
                    {
                        if (StringFromTXT[i] == '\n')
                            ColEnter++;
                    }
                    int pos = 0;
                    int colun = 0;
                    int[] PosEnter = new int[ColEnter];
                    
                    for (int i = 0; i < ColEnter; i++)
                    {
                        PosEnter[i] = -1;
                        razmStrColoum[i] = -1;
                    }



                    for (int i = 0; i < StringFromTXT.Length; i++)
                    {
                        if (StringFromTXT[i] == '\n')
                        {
                            PosEnter[pos] = i;
                            pos++;
                            colun++;
                        }
                    }

                    
                    columns = colun;
                    for (int i = 0; i < PosEnter.Length; i++)
                    {
                        if (i == 0)
                        {
                            razmStrColoum[i] = PosEnter[i];
                        }
                        else
                        {
                            razmStrColoum[i] = Math.Abs((PosEnter[i - 1] + 1) - PosEnter[i]);
                        }
                    }
                    string str = "";
                    for (int i = 0; i < razmStrColoum.Length; i++)
                    {
                        if (razmStrColoum[i] != -1)
                        {
                            str = str + razmStrColoum[i].ToString() + "\n";
                        }
                    }
                    int max = 0;

                    for (int i = 0; i < columns; i++)
                    {
                        if (max < razmStrColoum[i])
                        {
                            max = razmStrColoum[i];
                        }
                    }
                    DataTable dt = new DataTable();
                    dt = new DataTable();
                    for (int i = 0; i < columns; i++)
                    {
                        dt.Columns.Add((i + 1).ToString());
                    }
                    rows = ColEnter;
                    char[,] buf = new char[rows, 200];

                    for (int i = 0; i < rows; i++)
                    {
                        string st = StringFromTXT.Split('\n')[i];
                        for (int j = 0; j < razmStrColoum[i]; j++)
                        {
                            buf[i, j] = Convert.ToChar(st[j]);
                        }
                    }



                    rows = max;
                    for (int i = 0; i < rows; i++)
                    {
                        var nr = dt.NewRow();
                        for (int j = 0; j < columns; j++)
                        {
                            if (buf[j, i] != '\0')
                                nr[j] = buf[j, i];
                        }
                        dt.Rows.Add(nr);
                    }
                    txtVertical.Text = "";
                    DataGrid.ItemsSource = dt.DefaultView;
                }
                else
                {
                    string TextToTXT = "";

                    for (int i = 0; i < columns; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            var ci = new DataGridCellInfo(DataGrid.Items[j], DataGrid.Columns[i]);
                            var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
                            if (content != null)
                            {
                                TextToTXT = TextToTXT + content.Text + "";
                            }

                        }
                        TextToTXT = TextToTXT + "\n";
                    }
                    txtVertical.Text = TextToTXT;
                    DataTable dt = new DataTable();
                    dt = new DataTable();
                    for (int i = 0; i < columns; i++)
                    {
                        dt.Columns.Add((i + 1).ToString());
                    }
                    DataGrid.ItemsSource = dt.DefaultView;
                    NapravlColomn = true;
                    outDataVertical.Content = "<------";
                }
            }
            else
            {
                MessageBox.Show("dataGrid пустой, его необходимо его заполнить", "Малкеров Геннадий");
            }
        }
    }
}
