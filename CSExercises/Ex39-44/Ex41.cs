using System;

namespace CSExercises
{
    public class Ex41
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a string s1:");
                string s1 = Console.ReadLine();
                Console.Write("Please input a string s2:");
                string s2 = Console.ReadLine();
                if (InString(s1, s2))
                {
                    Console.WriteLine("s2 occurs in s1.");
                }
                else
                {
                    Console.WriteLine("s2 not occurs in s1.");
                }
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
        public static bool InString(string s1, string s2)
        {
            int i = 0;
            if (s1.Length < s2.Length)
                return false;
            else
            {
                for (i = 0; i < s1.Length - s2.Length + 1; i++)
                {
                    if (s2[0] == s1[i])
                    {
                        if (s2.CompareTo(s1.Substring(i, s2.Length)) == 0)
                        {
                            break;
                        }

                    }
                }
            }

            if (i == s1.Length - s2.Length + 1)
                return false;
            else
                return true;
        }
    }
}
