using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalcForm : Form
    {
        string inputData = "";
        string firstNumber = "";
        string secondNumber = "";
        char function;
        double result = 0.0;
        int inputCounter = 0;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "1";
            display.Text += inputData;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "2";
            display.Text += inputData;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "3";
            display.Text += inputData;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "4";
            display.Text += inputData;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "5";
            display.Text += inputData;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "6";
            display.Text += inputData;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "7";
            display.Text += inputData;
        }

        private void eigftButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "8";
            display.Text += inputData;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "9";
            display.Text += inputData;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            inputCounter++;
            display.Text = "";
            inputData += "0";
            display.Text += inputData;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            display.Text += ".";
            inputData += '.';
        }

        private void devisionButton_Click(object sender, EventArgs e)
        {
            function = '/';

            firstNumber = inputData;
            inputData = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';

            firstNumber = inputData;
            inputData = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';

            firstNumber = inputData;
            inputData = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';

            firstNumber = inputData;
            inputData = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            if (inputCounter > 0 && result != 0.0)
            {
                firstNumber = result.ToString();
            }

            secondNumber = inputData;

            double firstInput = Convert.ToDouble(firstNumber);
            double secondInput = Convert.ToDouble(secondNumber);

            if(function == '+')
            {
                result = firstInput + secondInput;
                display.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firstInput - secondInput;
                display.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstInput * secondInput;
                display.Text = result.ToString();
            }
            else if (function == '/')
            {
                if (secondInput == '0')
                {
                    display.Text = "Error";
                }
                else
                {
                    result = firstInput / secondInput;
                    display.Text = result.ToString();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputData = "";
            firstNumber = "";
            secondNumber = "";
            result = 0.0;
            display.Text = "0";
        }
    }
}
