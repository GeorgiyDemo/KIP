using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication2
{
    class Controller
    {
        private MainWindow view { set; get; }
        private long number1;
        private long number2;
        private string operation;

        public Controller(MainWindow view)
        {
            this.view = view;
            number1 = 0;
            number2 = 0;
            operation = "";
        }
        public void numberButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Content.ToString();
            long numberClicked = Convert.ToInt64(buttonText); //parse string to long
            if (operation == "")
            {
                number1 = number1 * 10 + numberClicked;
                view.txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + numberClicked;
                view.txtDisplay.Text = number2.ToString();
            }
        }
        public void operationButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Content.ToString();
            operation = buttonText;
            view.txtDisplay.Text = "0";
        }

        public void equalButtonClick()
        {
            string result = "";
            switch (operation)
            {
                case "+":
                    result = (number1 + number2).ToString();
                    break;
                case "-":
                    result = (number1 - number2).ToString();
                    break;
                case "*":
                    result = (number1 * number2).ToString();
                    break;
                case "/":
                    {
                        if (number2 != 0)
                            result = (number1 / number2).ToString();
                        else
                            result = "0";
                    }
                    break;
            }
            number1 = Convert.ToInt64(result);
            number2 = 0;
            view.txtDisplay.Text = result;
        }

        public void clearEntryButtonClick()
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            view.txtDisplay.Text = "0";
        }

        public void clearButtonClick()
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            view.txtDisplay.Text = "0";
        }

        public void backspaceButtonClick()
        {


            if (operation == "")
            {
                number1 = number1 / 10;
                view.txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 / 10;
                view.txtDisplay.Text = number2.ToString();
            }
        }

        public void positiveNegativeButtonClick()
        {
            if (operation == "")
            {
                number1 *= -1;
                view.txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                view.txtDisplay.Text = number2.ToString();
            }
        }

    }
}
