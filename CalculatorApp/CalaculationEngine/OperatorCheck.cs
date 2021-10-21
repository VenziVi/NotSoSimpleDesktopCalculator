
namespace CalculatorApp.CalaculationEngine
{
    public static class OperatorCheck
    {
        public static bool IsOperator(string input)
        {
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "/":
                    return true;
                case "x":
                    return true;
                default:
                    break;
            }
            return false;
        }
    }
}
