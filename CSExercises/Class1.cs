using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            try
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                bool c = Ex41.InString(a, b);
                if (c)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");

            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
