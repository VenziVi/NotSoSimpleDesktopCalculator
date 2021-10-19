﻿using System;
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
        string tempNumber = string.Empty;
        string dataFunction = string.Empty;
        string lastSymbol = string.Empty;
        string result = string.Empty;
        int resutlCounter = 0;

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
            InsertFunction("*");
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
                    display.Text += tempNumber;
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

            if (lastSymbol == "(")
            {
                functionDisplay.Text = dataFunction;
            }
            else
            {
                dataFunction += " (";
                functionDisplay.Text += dataFunction;
                lastSymbol = "(";
            }
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            functionDisplay.Text = string.Empty;

            if (lastSymbol == ")" || lastSymbol == "s")
            {
                functionDisplay.Text = dataFunction;
            }
            else if (lastSymbol == string.Empty)
            {
                functionDisplay.Text = "0";
            }
            else if (lastSymbol == "d")
            {
                dataFunction += " )";
                functionDisplay.Text += dataFunction;
                lastSymbol = ")";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tempNumber = string.Empty;
            dataFunction = string.Empty;
            display.Text = " 0";
            functionDisplay.Text = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

            string dataInput = functionDisplay.Text.TrimStart();
            result = CalculateResult(dataInput);

            display.Text = result;
            resutlCounter++;
            lastSymbol = "=";
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
    

