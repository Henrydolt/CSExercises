using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            try
            {
                int a, i, j;
                for (a = 5; a <= 10000; a++)
                {
                    j = 0;
                    for (i = 2; i <= a / 2; i++)
                    {
                        if (a % i == 0)
                            j = 1;
                    }
                    if (j == 0)
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
