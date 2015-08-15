using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The area of a triangle");
            double a, b, c, s, AREA;
            try
            {
                Console.Write("Please input the length of a:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the length of b:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please input the length of c:");
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                a = 0;
                b = 0;
                c = 0;
                s = 0;
                AREA = 0;
                Console.WriteLine("your input is wrong");
            }
            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                s = (a + b + c) / 2;
                AREA = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("the triangle's area is :{0}", AREA);
            }
            else
            {
                a = 0;
                b = 0;
                c = 0;
                s = 0;
                AREA = 0;
                Console.WriteLine("your input is wrong");
            }
            
        }
    }
}