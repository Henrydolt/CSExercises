using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a string:");
                string a = Console.ReadLine();
                string[] s = a.Split(' ');
                int i;
                for (i = 0; i < s.Length; i++)
                {
                    Console.Write((s[i].Substring(0, 1)).ToUpper() + s[i].Substring(1, s[i].Length - 1) + " ");
                }
                Console.WriteLine();

                
            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }            
        }
    }
}
