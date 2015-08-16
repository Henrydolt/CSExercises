using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a int number:");
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the square root of your number is: {0}", Math.Sqrt(number));
                
            }
            catch
            {
                number = 0;
                Console.WriteLine("your number is wrong");
            }
        }
    }
}
