using System;

namespace WEB_1001_January_2022_Calculator_Library
{
    public static class Calculator
    {
        public static double Calculate(int lValue, int rValue, string symbol)
        {
            double answer = 0;

            switch (symbol)
            {
                case "+":
                    answer = lValue + rValue;
                    break;
                case "-":
                    answer = lValue - rValue;
                    break;
                case "/":
                    answer = lValue / rValue;
                    break;
                case "*":
                    answer = lValue * rValue;
                    break;
            }

            return answer;
        }
    }
}
