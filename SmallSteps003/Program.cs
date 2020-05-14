using System;

namespace SmallSteps003
{
    public class Program
    {
        public static int a = 6;
        public static int b = 3;

        public static int result_addition;
        public static int result_substraction;
        public static int result_multiply;
        public static int result_division;

        public static void Main(string[] args)
        {
            result_addition = 9; // should be: a + b;
            result_substraction = 3;
            result_multiply = 18;
            result_division = 2;

            Console.WriteLine("Der Rechenking sagt {0} + {1} = {2}", a, b, result_addition);
            Console.WriteLine("Der Rechenking sagt {0} - {1} = {2}", a, b, result_substraction);
            Console.WriteLine("Der Rechenking sagt {0} * {1} = {2}", a, b, result_multiply);
            Console.WriteLine("Der Rechenking sagt {0} / {1} = {2}", a, b, result_division);
        }
    }
}
