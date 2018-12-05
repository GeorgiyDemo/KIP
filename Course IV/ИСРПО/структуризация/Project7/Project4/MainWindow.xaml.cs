using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace Project4
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


        private void Remover(string removestring)
        {
            MainListBox.Items.Remove(removestring);
        }

        private void Adder(string item)
        { 
          MainListBox.Items.Add(item); 
        }

        private bool Changer()
        {
            string text = MainListBox.SelectedItem.ToString();
            return true;
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Adder(CounterNameTextBox.Text);
            CounterNameTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            MainListBox.Items.Clear();
            CounterNameTextBox.Text = "";
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Remover(CounterNameTextBox.Text);
            CounterNameTextBox.Text = "";
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            int checker = MainListBox.Items.IndexOf(MainListBox.SelectedItem.ToString());
            MainListBox.Items.RemoveAt(checker);
            MainListBox.Items.Insert(checker, CounterNameTextBox.Text);
            CounterNameTextBox.Text = "";
        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CounterNameTextBox.Text = MainListBox.SelectedItem.ToString();
                
            }
            catch(Exception)
            {
                
            }
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            ArrayList MainArrayList = new ArrayList();
            foreach (object ListBox_object in MainListBox.Items)
                MainArrayList.Add(ListBox_object);
            MainArrayList.Sort();
            MainListBox.Items.Clear();
            foreach(object ListBox_object in MainArrayList)
                MainListBox.Items.Add(ListBox_object); 
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            DispatcherTimer ListTimer = new DispatcherTimer();
            ListTimer.Tick += new EventHandler(ListCounterTimer_Tick);
            ListTimer.Interval = new TimeSpan(0, 0, 1);
            ListTimer.Start();
        }

        private void ListCounterTimer_Tick(object sender, EventArgs e)
        {
            CountTextBox.Text = MainListBox.Items.Count.ToString();
        }
    }
}
