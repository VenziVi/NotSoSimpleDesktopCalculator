using CalculatorApp.CalaculationEngine;
using System.Collections.Generic;

namespace CalculatorApp.CalaculatorEngine
{
    public static class CalculatorParenthesesAlgorithm
    {
        public static string CalculateResult(string dataInput)
        {
            string[] expression = dataInput.Split(' ');

            Stack<string> operatorStack = new Stack<string>();
            string output = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                if (OperatorCheck.IsOperator(expression[i]))
                {
                    if (operatorStack.Count > 0)
                    {
                        var oldElementArity = OperationsOrder.OperationPrecedence
                            (operatorStack.Peek());
                        var elementArity = OperationsOrder.OperationPrecedence
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

            return output;
        }
    }
}
