using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a intager number:");
                int a = Convert.ToInt32(Console.ReadLine());
                int i, j=0;
                for (i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                        j = 1;
                }
                if (j == 1)
                    Console.WriteLine("Not Prime");
                else
                    Console.WriteLine("Prime");
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
