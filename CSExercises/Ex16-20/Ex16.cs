using System;

namespace CSExercises
{
    public class Ex16
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
                switch(gender){
                    case "M":
                        g = "Mr.";
                        Console.WriteLine("Good Morning " + g + name);
                        break;
                    case "F":
                        g = "Ms.";
                        Console.WriteLine("Good Morning " + g + name);
                        break;
                    default:
                        g = "";
                        Console.WriteLine("your input of gender is wrong.");
                        break;
                }
                
            }
            catch
            {
                Console.WriteLine("your input is wrong");
            }
        }
    }
}