using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Armstrong number");
            Console.Write("Please input a three-digit integer number(100-999):");
            int x, a, b, c;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x >= 100 && x <= 999)
                {
                    a = x / 100;
                    b = (x - a * 100) / 10;
                    c = x - a * 100 - b * 10;
                    if (x < (a * a * a + b * b * b + c * c * c) || x > (a * a * a + b * b * b + c * c * c))
                    {
                        Console.WriteLine("your number is not a Armstrong number");
                    }
                    else
                    {
                        Console.WriteLine("your number is a Armstrong number");
                    }
                }
                else
                {
                    Console.WriteLine("your number is not a three-digit integer number");
                }
            }
            catch
            {
                x = 0;
                Console.WriteLine("your number is wrong");
            }
        }
    }
}