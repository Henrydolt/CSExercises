using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(0,10);
            int guessnumber, i = 1;
            Console.Write("Please input a number(0-9):");
            try
            {
                guessnumber = Convert.ToInt32(Console.ReadLine());
                while (a != guessnumber)
                {
                    i++;
                    Console.Write("Try again:");
                    guessnumber = Convert.ToInt32(Console.ReadLine());
                }
                if (i <= 2)
                    Console.WriteLine("You are a Wizard! You guess {0} times.", i);
                else if(i <= 5)
                    Console.WriteLine("You are a good guess. You guess {0} times.", i);
                else
                    Console.WriteLine("You are lousy! You guess {0} times.", i);
            }
            catch
            {
                guessnumber = 0;
                Console.WriteLine("Your input is wrong.");
            }

        }
    }
}
