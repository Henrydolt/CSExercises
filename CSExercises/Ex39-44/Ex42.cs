namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int i = 0;
            if (s1.Length < s2.Length)
                return -1;
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
                return -1;
            else
                return i + 1;
        }
    }
}
