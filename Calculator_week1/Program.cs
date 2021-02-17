using System;

namespace Calculator_week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear user, I'm here so help you with some calculus..\nWhat would you like to calculate?\nI can handle addition, subtraction, multiplying and division.");
            Console.Write("First, tell me what calculation method you want to use.  A for addition, S for subtraction, M for multiplying and D for division. Fire away! ");

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    char assigmentChoice = char.Parse(Console.ReadLine().ToUpper() ?? "No, type in one character (A,S,M,D) and hitreturn for calculus method.");

                    //Use appropritate method call....
                    switch (assigmentChoice)
                    {
                        case 'A':
                            Addition();
                            break;
                        case 'S':
                            Subtraction();
                            break;
                        case 'M':
                            Multiplying();
                            break;
                        case 'D':
                            Division();
                            break;
                        default:
                            Console.WriteLine("That is not a valid character (A,S,M,D)!");
                            Console.ResetColor();
                            break;
                    }
                    Console.WriteLine("ok, quit or another math game? (q to quit)");
                    if (char.Parse(Console.ReadLine()) == 'q') 
                        System.Environment.Exit(1); 
                }
                catch
                {
                    Console.WriteLine("Pls, type in one character (A,S,M,D) for calculus method and hitreturn.");
                }
            }
            static double AskUserForInput(string what )
            {
                Console.Write($"Ok, hit me with {what}..  ");
                double ret = Double.Parse(Console.ReadLine());
                return ret;
            }
            static void Addition()
            {
                Console.WriteLine("Addition is fun, lets do it! ");
                double userInput1 = AskUserForInput("a number");
                double userInput2 = AskUserForInput("another number");
                double sum = userInput1 + userInput2;
                Console.WriteLine($"Sum is: {sum}");
            }
            static void Subtraction()
            {
                Console.WriteLine("Sutraction is lots of fun! ");
                double userInput1 = AskUserForInput("a number");
                double userInput2 = AskUserForInput("a number to subtract from the first number");
                double sum = userInput1 - userInput2;
                Console.WriteLine($"Sum is: {sum}");
            }
            static void Multiplying()
            {
                double userInput1 = AskUserForInput("a number");
                double userInput2 = AskUserForInput("a number to multiply with the first number");
                double sum = userInput1 * userInput2;
                Console.WriteLine($"Product is: {sum}");
            }
            static void Division()
            {
                double userInput1 = AskUserForInput("a number as numerator");
                double userInput2 = AskUserForInput("a number as denominator. Please observe this number must not be ZERO!");
                if (userInput2 != 0)
                {
                    double q = userInput1 / userInput2;
                    Console.WriteLine($"Quota is: {q}");
                }
                else
                {
                    Console.WriteLine("Division with zero is not possible. Pls try again");
                }
            }
        }

    }
}
