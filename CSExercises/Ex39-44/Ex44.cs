using System;

namespace CSExercises
{
    public class Ex44
    {
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
