using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            try
            {
                int i, j;

                for (int a = 1; a <= 1000; a++)
                {
                    j = 0;
                    for (i = 1; i <= a / 2; i++)
                    {
                        if (a % i == 0)
                            j = j + i;
                    }
                    if (j == a)
                        Console.WriteLine(a);
                }
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
