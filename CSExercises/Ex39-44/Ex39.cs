using System;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            Console.Write("Please input a number:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 1;
            for (int i = 0; i < a - 1; i++)
            {
                b = b * (a - 1);
            }
            Console.WriteLine("The factorial of {0} is {1}", a, b);
            return 0;
        }
    }
}
