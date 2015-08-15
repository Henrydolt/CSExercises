using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a temperature in Centigrade scale:");
            double C,F;
            try
            {
                C = Convert.ToDouble(Console.ReadLine());
                F = C * 1.8 + 32;
                Console.WriteLine("the Fahrenheit is:{0}", F);
            }
            catch
            {
                C = 0;
                F = 0;
                Console.WriteLine("your temperature is wrong");
            }
        }
    }
}
