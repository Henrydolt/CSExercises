using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] Sales = new int[12];
                int i, k, x = 0;
                for (i = 0; i < Sales.Length; i++)
                {
                    Console.Write("Enter sales for month {0}:", i);
                    Sales[i] = Convert.ToInt32(Console.ReadLine());
                }

                k = Sales[0];
                //maximum
                for(i = 1; i < 12; i++)
                {
                    if (Sales[i] > k)
                    {
                        k = Sales[i];
                        x = i;
                    }
                }
                Console.WriteLine("Maximum sales: {0}", x);

                //minimum
                x = 0;
                k = Sales[0];
                for (i = 1; i < 12; i++)
                {
                    if (Sales[i] < k)
                    {
                        k = Sales[i];
                        x = i;
                    }
                }
                Console.WriteLine("Minimum sales: {0}", x);

                //average
                k = Sales[0];
                for (i = 1; i < 12; i++)
                {
                    k = k + Sales[i];
                }
                Console.WriteLine("Average sales: {0}", Convert.ToDouble(k)/Sales.Length);
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
