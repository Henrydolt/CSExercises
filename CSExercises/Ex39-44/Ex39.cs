using System;

namespace CSExercises
{
    public class Ex39
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a number:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The factorial of {0} is {1}", a, Factorial(a));
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }

        }
        public static double Factorial(double a)
        {
            
            double b = 1;
            for (int i = 0; i < a - 1; i++)
            {
                b = b * (a - i);
            }
            
            return b;
        }
    }
}
