using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] a = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 59, 40, 14, 44, 3, 63, 81, 93, 79 };
                int i, j, k = 0, x = 0, temp;
                for (i = 0; i < a.Length - 1; i++)
                {
                    x = a[i + 1];
                    for (j = i + 1; j < a.Length; j++)
                    {
                        if (x < a[j])
                        {
                            x = a[j];
                            k = j;
                        }
                    }
                    if (a[i] < x)
                    {
                        temp = a[i];
                        a[i] = a[k];
                        a[k] = temp;
                    }
                }
                Console.WriteLine("Descending order:");
                for (i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
