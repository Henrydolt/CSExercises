using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
                Console.WriteLine("------------------------------------------");
                for (double i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0:0.0}\t{1:0.0##}\t{2:0.0##}\t\t{3:0.0##}", i, 1 / i, Math.Sqrt(i), i * i);
                }
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
