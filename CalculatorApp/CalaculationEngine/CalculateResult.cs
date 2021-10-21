using CalculatorApp.CalaculationEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.CalaculatorEngine
{
    public static class CalculateResult
    {
        public static string GetTotalResult(string dataInput)
        {
            string[] RPNExpression = dataInput
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(RPNExpression);

            while (stack.Count > 2)
            {
                List<string> elements = new List<string>();
                var currentElement = stack.Pop();
                while (!OperatorCheck.IsOperator(currentElement))
                {
                    elements.Add(currentElement);
                    currentElement = stack.Pop();
                }

                double firstNum = double.Parse(elements[elements.Count - 2]);
                double secondNum = double.Parse(elements[elements.Count - 1]);

                double result = PartialCalculation.PartialOperation(currentElement, firstNum, secondNum);

                stack.Push(result.ToString());

                for (int i = elements.Count - 3; i >= 0; i--)
                {
                    stack.Push(elements[i]);
                }
            }

            return stack.Peek();
        }
    }
}
