using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input the salary($):");
            double salary,total;
            try
            {
                salary = Convert.ToDouble(Console.ReadLine());
                total = salary * (1 + 0.1 + 0.03);
                Console.WriteLine("the total income is:{0:#.00}",total);
            }
            catch
            {
                salary = 0;
                total = 0;
                Console.WriteLine("your salary is wrong");
            }
        }
    }
}
