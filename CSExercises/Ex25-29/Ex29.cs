using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a intager number:");
                int a = Convert.ToInt32(Console.ReadLine());
                int i, j = 0;
                for (i = 1; i <= a/2; i++)
                {
                    if (a % i == 0)
                        j = j + i;
                }
                if (j == a)
                    Console.WriteLine("Perfect Number");
                else
                    Console.WriteLine("Not Perfect Number");
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
