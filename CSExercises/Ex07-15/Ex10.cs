using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Compute the distance between 1 and 2");
            double x1, x2, y1, y2, D;
            
            
            try
            {
                Console.Write("Please input the value of x1:");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the value of y1:");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the value of x2:");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the value of y2:");
                y2 = Convert.ToDouble(Console.ReadLine());
                D = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                Console.WriteLine("the distance between the two points is:" + D);
            }
            catch
            {
                x1 = 0;
                y1 = 0;
                x2 = 0;
                y2 = 0;
                D = 0;
                Console.WriteLine("your input is wrong");
            }
        }
    }
}
