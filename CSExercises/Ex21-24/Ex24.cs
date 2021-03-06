using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a integer number:");
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                double G = Convert.ToDouble(r.Next(1, N));
                while (G * G >= N + 0.00001 || G * G <= N - 0.00001) 
                    G = (G + N / G) / 2;

                Console.WriteLine("The square root of the number is " + G);
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
