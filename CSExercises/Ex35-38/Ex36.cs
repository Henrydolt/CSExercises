using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            try
            {
                //a
                Console.WriteLine("Please enter a string:");
                string s = Console.ReadLine();
                int i, j = 0, k = 0;
                for (i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                    {
                        Console.WriteLine("Not Palindrome");
                        k = 1;
                        break;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Palindrome");
                }

                //b
                k = 0;
                Console.WriteLine("Please enter a string:");
                s = Console.ReadLine().ToLower();
                for (i = 0; i < s.Length / 2; i++)
                {
                    if (i + j >= s.Length - 1)
                    {
                        break;
                    }
                    else if (s[i] < 'a' && s[i] > 'Z')
                        i++;
                    else
                    {
                        if (s[s.Length - j - 1] < 'a' && s[s.Length - j - 1] > 'Z')
                            j++;
                        else if (s[i] != s[j])
                        {
                            Console.WriteLine("Not Palindrome");
                            k = 1;
                            break;
                        }
                        j++;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Palindrome");
                }

                

                
            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }
        }
    }
}
