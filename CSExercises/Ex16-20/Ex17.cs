using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input your name:");
            try
            {
                string name = Console.ReadLine();
                Console.Write("Please input your gender(M/F):");
                string gender = Console.ReadLine();
                string g;
                Console.Write("Please input your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                if (gender == "M")
                {
                    if (age >= 40)
                    {
                        g = "Uncle";
                    }
                    else
                    {
                        g = "Mr.";
                    }
                    Console.WriteLine("Good morning {0} {1}", g, name);
                }
                else if (gender == "F")
                {
                    
                    if (age >= 40)
                    {
                        g = "Aunty";
                    }
                    else
                    {
                        g = "Ms.";
                    }
                    Console.WriteLine("Good morning {0} {1}", g, name);
                }
                else
                {
                    Console.WriteLine("your gender or age of gender is wrong");
                }
            }
            catch
            {
                Console.WriteLine("your input is wrong");
            }
        }
    }
}