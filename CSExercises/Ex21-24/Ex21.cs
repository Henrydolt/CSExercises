using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            
            try
            {
                int a = 0;
                Console.Write("Please input a integer number(1-100):");
                a = Convert.ToInt32(Console.ReadLine());
                while (a != 88)
                {
                    Console.Write("Wrong.Please input another integer number(1-100):");
                    a = Convert.ToInt32(Console.ReadLine());
                } 
                Console.WriteLine("Lucky you ...");
            }
            catch
            {
                Console.Write("Your input is wrong.");
            }
        }
    }
}
