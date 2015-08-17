using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a integer number:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int i;
                Console.WriteLine("The increment counter:");
                for (i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                        Console.WriteLine(i);
                }
                Console.WriteLine("The decrement counter:");
                for (i = a; i > 0; i--)
                {
                    if (a % i == 0)
                        Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
