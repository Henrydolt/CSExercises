using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            
            try
            {
                //a
                Console.WriteLine("Please enter a phrase:");
                string s = Console.ReadLine();
                char[] a = new char[]{'a','e','i','o','u'};
                int i, j, k = 0;
                for (i = 0; i < s.Length; i++)
                {
                    for(j = 0; j < a.Length; j++) 
                    {
                        if (s[i] == a[j])
                        {
                            k++;
                        }
                    }
                    
                }
                Console.WriteLine("Total number of vowels:{0}", k);
                //b
                Console.WriteLine("Please enter a phrase:");
                string s1 = Console.ReadLine();
                for (i = 0; i < a.Length; i++)
                {
                    k = 0;
                    for (j = 0; j < s.Length; j++)
                    {
                        if (s[j] == a[i])
                        {
                            k++;
                        }
                    }
                    Console.WriteLine("Number of {1}:{0}", k, a[i]);
                }
                

            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }
        }
    }
}
