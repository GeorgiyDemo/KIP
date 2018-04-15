using Microsoft.Win32;
using System;
using System.Windows;

namespace FileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Name of file in use
        /// </summary>
        private string fileName = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file after the user has been prompted for the file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private static string GetFileName()
        {
            string fname = String.Empty;
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = @"W:\Projects\KIP\Course III\ПО\Task11\";
            openFileDlg.DefaultExt = ".txt";
            openFileDlg.Filter = "Текстовые документы (.txt)|*.txt";
            if (openFileDlg.ShowDialog() == true)
                fname = openFileDlg.FileName;
            else
                MessageBox.Show("Файл не выбран!");
            return fname;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            fileName = GetFileName();
            editor.Text = fileName != "" ? TextFileOperations.ReadTextFileContents(fileName) : "";
         }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (fileName != "")
                TextFileOperations.WriteTextFileContents(fileName, editor.Text);
        }
    }   
}
