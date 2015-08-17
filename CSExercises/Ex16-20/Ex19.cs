using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input your distance travelled(km):");
            try
            {
                double D = Math.Ceiling(Convert.ToDouble(Console.ReadLine()) * 10) / 10; //km

                if (D >= 0 && D <= 0.5)
                    Console.WriteLine("Your cost is:{0:0.00}", 2.4);
                else if (D <= 9)
                    Console.WriteLine("Your cost is:{0:0.00}", (2.4 + (D - 0.5) * 0.04 * 10));
                else 
                    Console.WriteLine("Your cost is:{0:0.00}", (2.4 + 8.5 * 0.04 * 10) + (D - 9) * 0.05 * 10);
            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }
        }
    }
}