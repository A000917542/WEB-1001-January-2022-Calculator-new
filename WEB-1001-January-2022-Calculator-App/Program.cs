using System;
using WEB_1001_January_2022_Calculator_Library;

namespace WEB_1001_January_2022_Calculator_App
{
    internal class Program
    {
        private const string INVALID_EQUATION_ERROR = "Please provide a valid equation. It should be in the form 1 1 +";

        static void Main()
        {
            bool whileRun = true;
            Console.WriteLine("Brent's Calculator");
            do
            {
                Console.WriteLine("Please enter a calcualtion ex. 1 1 -");
                String equation = Console.ReadLine();
                if (equation != null)
                {
                    if (equation == "quit")
                    {
                        whileRun = false;
                    }
                        

                    String[] args = equation.Split(' ');

                    if (args.Length == 3)
                    {
                        string symbol = args[2];
                        int lValue = 0;
                        int rValue = 0;

                        if (int.TryParse(args[0], out lValue) && int.TryParse(args[1], out rValue))
                        {
                            double answer = Calculator.Calculate(lValue, rValue, symbol);

                            Console.WriteLine($"The answer to {equation} is {answer}.");
                        }
                        else
                        {
                            Console.WriteLine(INVALID_EQUATION_ERROR);
                        }
                    }
                    else
                    {
                        Console.WriteLine(INVALID_EQUATION_ERROR);
                    }
                }
                else
                {
                    Console.WriteLine(INVALID_EQUATION_ERROR);
                }
            } while (whileRun);
        }
    }
}
