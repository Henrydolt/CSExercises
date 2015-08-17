using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input your scored marks:");
            try
            {
                double mark = Convert.ToDouble(Console.ReadLine());
                char Grade;
                if (mark >= 80 && mark <= 100)
                {
                    Grade = 'A';
                    Console.WriteLine("You scored {0} marks which is {1} grade.", mark, Grade);
                }
                else if (mark >= 60 && mark < 80)
                {
                    Grade = 'B';
                    Console.WriteLine("You scored {0} marks which is {1} grade.", mark, Grade);
                }
                else if (mark >= 40 && mark < 60)
                {
                    Grade = 'C';
                    Console.WriteLine("You scored {0} marks which is {1} grade.", mark, Grade);
                }
                else if (mark >= 0 && mark < 40)
                {
                    Grade = 'F';
                    Console.WriteLine("You scored {0} marks which is {1} grade.", mark, Grade);
                }
                else
                {
                    Grade = ' ';
                    Console.WriteLine("Your marks is wrong.");
                }
                    
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}