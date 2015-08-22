using System;

namespace CSExercises
{
    public class Ex43
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.Write("Please input a integer number:");
                //Console.WriteLine("The hexadecimal number of your input is:{0}", Hex(Convert.ToInt32(Console.ReadLine())));
                Console.WriteLine("decimal\thexadecimal");
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i + "\t" + Hex(i));
                }
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
        public static string Hex(int a)
        {
            int[] b = new int[100];
            int i = 0;
            string[] c = new string[100];
            do
            {
                b[i] = a % 16;
                a = a / 16;
                i++;

            } while (a > 16);
            int j;
            for (j = 0; j < i; j++)
            {
                if (b[j] < 10)
                    c[j] = Convert.ToString(b[j]);
                else
                    switch (b[j])
                    {
                        case 10:
                            c[j] = "A";
                            break;
                        case 11:
                            c[j] = "B";
                            break;
                        case 12:
                            c[j] = "C";
                            break;
                        case 13:
                            c[j] = "D";
                            break;
                        case 14:
                            c[j] = "E";
                            break;
                        case 15:
                            c[j] = "F";
                            break;
                        default:
                            break;
                    }
            }
            string d = "";
            if (a > 0)
            {
                d = Convert.ToString(a);
            }
            for (j = i - 1; j >= 0; j--)
            {
                d = d + c[j];
            }

            return d;
        }
    }
}
