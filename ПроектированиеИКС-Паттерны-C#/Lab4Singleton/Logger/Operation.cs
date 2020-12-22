namespace Lab4Singleton.Logger
{
    internal static class Operation
    {
        public static double Run(char operationCode, int operand)
        {
            var log = Log.GetLog;
            double result = 0;

            switch (operationCode)
            {
                case '+':
                    result += operand;
                    log.ExecuteLog("Addition " + operand);
                    break;
                case '-':
                    result -= operand;
                    log.ExecuteLog("Substraction " + operand);
                    break;
                case '*':
                    result *= operand;
                    break;
                case '/':
                case ':':
                    result /= operand;
                    break;
            }

            return result;
        }
    }
}