using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 25; i++)
                {
                    Console.WriteLine("The square root of {0} is {1:0.00000}", i, SQT(i));
                }

            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }

        public static double SQT(int y)
        {
            Random r = new Random();
            double a = Convert.ToDouble(r.Next(1, y + 1));
            while (a * a >= y + 0.00001 || a * a <= y - 0.00001)
                a = (a + y / a) / 2;
            return a;
        }
    }
}
