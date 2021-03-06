using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            try
            {
                int[,] a = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, 
                    { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 },
                    { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
                int[] m = new int[4];
                int i=0, j, sum;
                //total marks
                for (i = 0; i < 12; i++)
                {
                    sum = 0;
                    for (j = 0; j < 4; j++)
                    {
                        sum = sum + a[i,j];
                    }
                    Console.WriteLine("Total Marks of Student {0} is: {1}", i, sum);
                }
                //class average
                for (i = 0; i < 4; i++)
                {
                    sum = 0;
                    for (j = 0; j < 12; j++)
                    {
                        sum = sum + a[j, i];
                    }
                    m[i] = sum / 12;
                    Console.WriteLine("Class average of subject {0} is: {1}", i, m[i]);
                }
                //standard deviation
                for (i = 0; i < 4; i++)
                {
                    sum = 0;
                    for (j = 0; j < 12; j++)
                    {
                        sum = sum + (a[j, i] - m[i]) * (a[j, i] - m[i]);
                    }

                    Console.WriteLine("Standard deviation of subject {0} is: {1}", i, Math.Sqrt(sum / 12));
                }
                Console.WriteLine("Overall average is:{0}", Convert.ToDouble(m[0] + m[1] + m[2] + m[3]) / 4);

                
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
