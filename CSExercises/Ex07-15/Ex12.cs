using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ABC Taxi Company");
            Console.Write("Please input the distance traveled:");
            double D, total;
            try
            {
                D = Convert.ToDouble(Console.ReadLine());
                total = 2.40 + 0.4 * D;
                Console.WriteLine("the total fare is:{0:#.00}", Math.Round(total * 10) * 0.1);
            }
            catch
            {
                D = 0;
                total = 0;
                Console.WriteLine("your input is wrong");
            }
        }
    }
}
