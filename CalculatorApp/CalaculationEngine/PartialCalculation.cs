using System;

namespace CalculatorApp.CalaculationEngine
{
    public static class PartialCalculation
    {
        public static double PartialOperation(string currentElement, double firstNum, double secondNum)
        {
            switch (currentElement)
            {
                case "+":
                    return firstNum + secondNum;
                case "-":
                    return firstNum - secondNum;
                case "/":
                    return firstNum / secondNum;
                case "x":
                    return firstNum * secondNum;
                default:
                    break;
            }

            throw new ArgumentException();
        }
    }
}
