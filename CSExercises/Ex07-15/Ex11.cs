using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
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
                Console.WriteLine("the total fare is:{0}", total);
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
