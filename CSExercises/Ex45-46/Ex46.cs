using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            try
            {
                //part1
                int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] b = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                Random r = new Random();
                int c;
                for (int i = 0; i < 50; i++)
                {
                    c = r.Next(0, 10);
                    switch (c)
                    {
                        default:
                            break;
                        case 0:
                            b[0]++;
                            break;
                        case 1:
                            b[1]++;
                            break;
                        case 2:
                            b[2]++;
                            break;
                        case 3:
                            b[3]++;
                            break;
                        case 4:
                            b[4]++;
                            break;
                        case 5:
                            b[5]++;
                            break;
                        case 6:
                            b[6]++;
                            break;
                        case 7:
                            b[7]++;
                            break;
                        case 8:
                            b[8]++;
                            break;
                        case 9:
                            b[9]++;
                            break;
                    }
                }
                Console.WriteLine("Nmuber\tCount");
                for (int j = 0; j < 10; j++)
                    Console.WriteLine("  "+a[j] + "\t  " + b[j]);
                Console.WriteLine();
                //part2
                Console.WriteLine("Nmuber");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("  " + a[j] + "  ");
                    for (int k = 0; k < b[j]; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                    

            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}
