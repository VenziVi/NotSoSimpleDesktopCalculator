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
        //string inputData = string.Empty;
        //string firstNumber = string.Empty;
        //string secondNumber = string.Empty;
        //char function;
        //double result = 0.0;
        //int inputCounter = 0;

        string fullNumber = string.Empty;
        string tempNumber = string.Empty;
        string dataFunction = string.Empty;
        string lastSymbol = string.Empty;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "1";
            }
            else
            {
                tempNumber += " 1";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "2";
            }
            else
            {
                tempNumber += " 2";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "3";
            }
            else
            {
                tempNumber += " 3";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "4";
            }
            else
            {
                tempNumber += " 4";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "5";
            }
            else
            {
                tempNumber += " 5";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "6";
            }
            else
            {
                tempNumber += " 6";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "7";
            }
            else
            {
                tempNumber += " 7";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void eigftButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "8";
            }
            else
            {
                tempNumber += " 8";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "9";
            }
            else
            {
                tempNumber += " 9";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;
            if (lastSymbol == "." || lastSymbol == "d")
            {
                tempNumber += "0";
            }
            else
            {
                tempNumber += " 0";
            }
            functionDisplay.Text += tempNumber;
            lastSymbol = "d";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol != "." && lastSymbol != "s")
            {
                tempNumber += ".";
                functionDisplay.Text += tempNumber;
                lastSymbol = ".";
            }
            else
            {
                functionDisplay.Text = tempNumber;
            }
            
        }

        private void devisionButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol  != "." && lastSymbol != "s")
            {
                tempNumber += " /";
                functionDisplay.Text += tempNumber;
                lastSymbol = "s";
            }
            else
            {
                functionDisplay.Text = tempNumber;
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol != "." && lastSymbol != "s")
            {
                tempNumber += " *";
                functionDisplay.Text += tempNumber;
                lastSymbol = "s";
            }
            else
            {
                functionDisplay.Text = tempNumber;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol != "." && lastSymbol != "s")
            {
                tempNumber += " -";
                functionDisplay.Text += tempNumber;
                lastSymbol = "s";
            }
            else
            {
                functionDisplay.Text = tempNumber;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol != "." && lastSymbol != "s")
            {
                tempNumber += " +";
                functionDisplay.Text += tempNumber;
                lastSymbol = "s";
            }
            else
            {
                functionDisplay.Text = tempNumber;
            }
        }

        private void leftBracket_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol == "(")
            {
                functionDisplay.Text = tempNumber;
            }
            else
            {
                tempNumber += " (";
                functionDisplay.Text += tempNumber;
                lastSymbol = "(";
            }
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol == ")" || lastSymbol == "s")
            {
                functionDisplay.Text = tempNumber;
            }
            else if (lastSymbol == string.Empty)
            {
                functionDisplay.Text = "0";
            }
            else if (lastSymbol == "d")
            {
                tempNumber += " )";
                functionDisplay.Text += tempNumber;
                lastSymbol = ")";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fullNumber = string.Empty;
            tempNumber = string.Empty;
            dataFunction = string.Empty;
            display.Text = " 0";
            functionDisplay.Text = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            string dataInput = functionDisplay.Text.TrimStart();
            string result = CalculateResult(dataInput);

            display.Text = result;
        }

        private string CalculateResult(string dataInput)
        {
            string[] expression = dataInput.Split(' ');

            Stack<string> operatorStack = new Stack<string>();
            string output = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperator(expression[i]))
                {
                    if (operatorStack.Count > 0)
                    {
                        var oldElementArity = OperationPrecedence
                            (operatorStack.Peek());
                        var elementArity = OperationPrecedence
                            (expression[i]);

                        if (oldElementArity >= elementArity)
                        {
                            output += operatorStack.Pop() + " ";
                        }
                    }
                    operatorStack.Push(expression[i]);

                }
                else if (expression[i] == "(")
                {
                    operatorStack.Push(expression[i]);
                }
                else if (expression[i] == ")")
                {
                    while (operatorStack.Peek() != "(")
                    {
                        output += operatorStack.Pop() + " ";
                    }

                    operatorStack.Pop();
                }
                else
                {
                    output += expression[i] + " ";
                }
            }

            while (operatorStack.Count > 0)
            {
                output += operatorStack.Pop() + " ";
            }

            Console.WriteLine(output);

            string[] RPNExpression = output.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToArray();
            Stack<string> stack = new Stack<string>(RPNExpression);


            while (stack.Count > 2)
            {
                List<string> elements = new List<string>();
                var currentElement = stack.Pop();
                while (!IsOperator(currentElement))
                {
                    elements.Add(currentElement);
                    currentElement = stack.Pop();
                }

                double firstNum = double.Parse(elements[elements.Count - 2]);
                double secondNum = double.Parse(elements[elements.Count - 1]);

                double result = PerformOperation(currentElement, firstNum, secondNum);

                stack.Push(result.ToString());

                for (int i = elements.Count - 3; i >= 0; i--)
                {
                    stack.Push(elements[i]);
                }
            }

            return stack.Peek();
        }

        private static double PerformOperation(string currentElement, double firstNum, double secondNum)
        {
            switch (currentElement)
            {
                case "+":
                    return firstNum + secondNum;
                case "-":
                    return firstNum - secondNum;
                case "/":
                    return firstNum / secondNum;
                case "*":
                    return firstNum * secondNum;
                default:
                    break;
            }

            throw new NotImplementedException();
        }

        static int OperationPrecedence(string input)
        {
            switch (input)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "/":
                    return 3;
                case "*":
                    return 3;
                case "(":
                    return 1;
                default:
                    break;
            }
            throw new ArgumentException();
        }


        static bool IsOperator(string input)
        {
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "/":
                    return true;
                case "*":
                    return true;
                default:
                    break;
            }
            return false;
        }
    }
}
    

