using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalcForm : Form
    {
        string tempNumber = string.Empty;
        string dataFunction = string.Empty;
        string lastSymbol = string.Empty;
        string result = string.Empty;
        int resutlCounter = 0;
        int braceletCount = 0;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            InsertNumber("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            InsertNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            InsertNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            InsertNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            InsertNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            InsertNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            InsertNumber("7");
        }

        private void eigftButton_Click(object sender, EventArgs e)
        {
            InsertNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertNumber("9");
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            InsertNumber("0");
        }

        private void InsertNumber(string number)
        {
            functionDisplay.Text = string.Empty;
            display.Text = string.Empty;

            if (lastSymbol == "=")
            {
                dataFunction = string.Empty;
                tempNumber = string.Empty;
            }

            if (lastSymbol == "s" || lastSymbol == "(" || lastSymbol == ")")
            {
                tempNumber = string.Empty;
            }

            if (lastSymbol == "." || lastSymbol == "d")
            {
                dataFunction += number;
                tempNumber += number;
            }
            else
            {
                dataFunction += " " + number;
                tempNumber += number;
            }
            functionDisplay.Text += dataFunction;
            display.Text = tempNumber;
            lastSymbol = "d";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            InsertFunction(".");
        }

        private void devisionButton_Click(object sender, EventArgs e)
        {
            InsertFunction("/");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InsertFunction("x");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            InsertFunction("-");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            InsertFunction("+");
        }

        private void InsertFunction(string functionSign)
        {
            if (resutlCounter % 2 != 0 && lastSymbol != "d")
            {
                dataFunction = result;
                functionDisplay.Text = result;
                resutlCounter++;
            }

            functionDisplay.Text = string.Empty;

            if (lastSymbol != "." && lastSymbol != "s")
            {
                if (functionSign == ".")
                {
                    dataFunction += ".";
                    tempNumber += ".";
                    functionDisplay.Text += dataFunction;
                    lastSymbol = ".";
                    display.Text = tempNumber;
                }
                else
                {
                    dataFunction += " " + functionSign;
                    functionDisplay.Text += dataFunction;
                    lastSymbol = "s";
                }
            }
            else
            {
                functionDisplay.Text = dataFunction;
                display.Text += dataFunction;
            }
        }

        private void leftBracket_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol == "d")
            {
                functionDisplay.Text = dataFunction;
            }
            else
            {
                dataFunction += " (";
                functionDisplay.Text += dataFunction;
                lastSymbol = "(";
                braceletCount++;
            }
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (braceletCount == 0 || lastSymbol == "s")
            {
                functionDisplay.Text = dataFunction;
            }
            else if (lastSymbol == string.Empty)
            {
                functionDisplay.Text = "";
            }
            else if (lastSymbol == "d" || (lastSymbol == ")" && braceletCount > 0))
            {
                dataFunction += " )";
                functionDisplay.Text += dataFunction;
                lastSymbol = ")";
                braceletCount--;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tempNumber = string.Empty;
            dataFunction = string.Empty;
            display.Text = " 0";
            functionDisplay.Text = string.Empty;
            braceletCount = 0;
            resutlCounter = 0;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            if (braceletCount == 0)
            {
                string dataInput = functionDisplay.Text.TrimStart();
                result = CalculatorEngin.CalculateResult(dataInput);

                display.Text = result;
                resutlCounter++;
                lastSymbol = "=";
            }
        }
    }
}
    

