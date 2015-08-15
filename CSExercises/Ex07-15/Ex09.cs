using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input the value of x:");
            double x,y;
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("the value of y is:{0}", y);
            }
            catch
            {
                x = 0;
                y = 0;
                Console.WriteLine("your input is wrong");
            }
        }
    }
}
