using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            try
            {
                //a
                int x = -5;
                int y ;
                Console.WriteLine("X\t\tY");
                Console.WriteLine("------------------");
                for (x = -5; x <= 5; x++)
                {
                    y = 2 * x * x - 4 * x + 3;
                    Console.WriteLine("{0:0.0}\t{1:0.0}", x, y);
                }

                //b
                for (x = 1; x <= 20; x++)
                {
                    for (y = 2 * x * x - 4 * x + 3; y > 0; y--) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    
                }

            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
