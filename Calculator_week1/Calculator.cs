using System;

namespace Calculator_week3
{
    public static class Calculator
    {
        public static double AskUserForInput(string what = "a number")
        {
            Console.Write($"Ok, hit me with {what}..  ");
            double ret = Double.Parse(Console.ReadLine());
            return ret;
        }
        public static double Addition(double userInput1, double userInput2)
        {
            double sum = userInput1 + userInput2;
            return sum;
        }
        /// <summary>
        /// Overloaded, acepting array input.
        /// </summary>
        /// <param name="userInput1"></param>
        /// <returns></returns>
        public static double Addition(double[] userInput1)
        {
            double sum = 0;
            foreach (double item in userInput1)
            {
                sum = sum + item;
            }
            return sum;
        }
        public static double Subtraction(double userInput1, double userInput2)
        {
            double sum = userInput1 - userInput2;
            return sum;
        }
        /// <summary>
        /// Overloaded, accepting array input
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static double Subtraction(double[] userInput)
        {
            double sum = 0;
            foreach (double item in userInput)
            {
                sum = sum - item;
            }
            return sum;
        }
        public static double Multiplying(double userInput1, double userInput2)
        {
            double prod = userInput1 / userInput2; ;
            return prod;
        }
        public static double Division(double userInput1, double userInput2)
        {
            double q = 0;
            if (userInput2 != 0)
            {
                q = userInput1 / userInput2;
            }
            return q;
        }
    }
}
