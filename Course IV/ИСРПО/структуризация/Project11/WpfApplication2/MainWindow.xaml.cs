using System;
using System.Windows;

namespace WpfApplication2
{
    public partial class MainWindow : Window
    {
        Controller control;  

        public MainWindow()
        {
            InitializeComponent();
            control = new Controller(this);
        }

        void numberButtonClick(object sender, EventArgs e)
        {
            control.numberButtonClick(sender, e);
        }

        void operationButtonClick(object sender, EventArgs e)
        {
            control.operationButtonClick(sender, e);
        }

        void equalButtonClick(object sender, EventArgs e)
        {
            control.equalButtonClick();
        }

        void clearEntryButtonClick(object sender, EventArgs e)
        {
            control.clearEntryButtonClick();
        }

        void clearButtonClick(object sender, EventArgs e)
        {
            control.clearButtonClick();
        }

        void backspaceButtonClick(object sender, EventArgs e)
        {
            control.backspaceButtonClick();
        }

        void positiveNegativeButtonClick(object sender, EventArgs e)
        {
            control.positiveNegativeButtonClick();
        }

    }
}
