using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            try
            {
                //a
                int[] mark = new int[] { 63, 29, 75, 82, 55 };
                int i, j, k, n, temp;
                n = 0;
                for (i = 0; i < mark.Length; i++)
                {
                    k = mark[i];
                    for (j = i + 1; j < mark.Length; j++)
                    {
                        if (k < mark[j])
                        {
                            k = mark[j];
                            n = j;
                        }
                    }
                    if (mark[i] < k)
                    {
                        temp = mark[i];
                        mark[i] = mark[n];
                        mark[n] = temp;
                    }
                }
                Console.Write("Descending order:");
                for (i = 0; i < mark.Length; i++)
                    Console.Write(mark[i] + " ");
                Console.WriteLine();
                
                //b
                string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
                string a = "";
                n = 0;
                for (i = 0; i < name.Length; i++)
                {
                    a = name[i];
                    for (j = i + 1; j < name.Length; j++)
                    {
                        if (a.CompareTo(name[j]) == 1)
                        {
                            a = name[j];
                            n = j;
                        }
                    }
                    if (name[i].CompareTo(a) == 1)
                    {
                        a = name[i];
                        name[i] = name[n];
                        name[n] = a;
                    }
                }
                Console.WriteLine("Alphabetical name:");
                for (i = 0; i < name.Length; i++)
                    Console.WriteLine(name[i]);


            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }
        }
    }
}
