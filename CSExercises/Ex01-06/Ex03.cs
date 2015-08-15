using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a double precision number:");
            double number;
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("the square of your number is: " + number * number);
            }
            catch
            {
                number = 0;
                Console.WriteLine("your number is wrong");
            }
        }
    }
}
