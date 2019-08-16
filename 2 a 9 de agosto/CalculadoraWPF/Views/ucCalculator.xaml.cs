using System;
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

namespace CalculadoraWPF.Views
{
    /// <summary>
    /// Interação lógica para ucCalculator.xam
    /// </summary>
    public partial class ucCalculator : UserControl
    {



        double number1 = 0;
        double number2 = 0;
        string operation = "";

        public ucCalculator()
        {
            InitializeComponent();
        }

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) +9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) ;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) ;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void Button_Click_Subt(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

       

        private void Button_Click_Multi(object sender, RoutedEventArgs e)
        {
            {
                operation = "*";
                txtDisplay.Text = "0";
            }
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            {
                operation = "/";
                txtDisplay.Text = "0";
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            switch(operation )
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }


        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }
    }
}
