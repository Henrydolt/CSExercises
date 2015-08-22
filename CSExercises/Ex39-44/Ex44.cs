using System;

namespace CSExercises
{
    public class Ex44
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string s:");
            string s = Console.ReadLine();
            Console.Write("Please input a character c1:");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Please input a character c2:");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Substitute(s, c1, c2));

        }
        public static string Substitute(string s, char c1, char c2)
        {

            char[] a = new char[s.Length];
            
            for (int i = 0; i < s.Length; i++)
                a[i] = Convert.ToChar(s[i]);
            for (int j = 0; j < s.Length; j++) 
            {
                if (a[j] == c1)
                {
                    a[j] = c2;
                }
            }
            s = new string(a);
            
            return s;
        }
    }
}
