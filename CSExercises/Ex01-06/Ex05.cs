using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a double precision number:");
            double number;
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("the square of your number is: {0:0.000}",Math.Sqrt(number));
            }
            catch
            {
                number = 0;
                Console.WriteLine("your number is wrong");
            }
        }
    }
}
