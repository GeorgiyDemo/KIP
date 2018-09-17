using System;

using System.Windows;


namespace NormalProgramma
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

        private void Vibor_Click(object sender, RoutedEventArgs e)
        {
            int ind = Chose.SelectedIndex;
            switch(ind)
            {
                case 0: Shar Shar_obj = new Shar();
                    this.Hide();
                    Shar_obj.ShowDialog();
                    
                    break;
                case 1:
                    Konyc Konyc_obj = new Konyc();
                    this.Hide();
                    Konyc_obj.ShowDialog();

                    break;
                case 2:
                    Ycechkonyc Ycechkonyc_obj = new Ycechkonyc();
                    this.Hide();
                    Ycechkonyc_obj.ShowDialog();

                    break;
                case 3:
                    barrelxaml barrelxamlc_obj = new barrelxaml();
                    this.Hide();
                    barrelxamlc_obj.ShowDialog();
                    
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы дейтсвительно хотите выйти?","Малкеров Геннадий", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
                Application.Current.Shutdown();
            }
        }
    }
}
