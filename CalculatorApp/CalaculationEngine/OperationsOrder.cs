using System;

namespace CalculatorApp.CalaculationEngine
{
    public static class OperationsOrder
    {
        public static int OperationPrecedence(string input)
        {
            switch (input)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "/":
                    return 3;
                case "x":
                    return 3;
                case "(":
                    return 1;
                default:
                    break;
            }

            throw new ArgumentException();
        }
    }
}
