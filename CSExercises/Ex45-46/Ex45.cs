using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the amount:");
                int a = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()) * 100);
                int[] b = new int[5];
                int[] c = new int[] { 100, 50, 20, 10, 5 };
                b[0] = a / 100;
                b[1] = (a - b[0] * 100) / 50;
                b[2] = (a - b[0] * 100 - b[1] * 50) / 20;
                b[3] = (a - b[0] * 100 - b[1] * 50 - b[2] * 20) / 10;
                if (a % 10 > 3 && a % 10 <= 8)
                    b[4] = 1;
                else
                    b[4] = 0;
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < b[i]; j++)
                        Console.WriteLine(c[i] + "c");
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
