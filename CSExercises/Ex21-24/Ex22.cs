using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            try//
            {
                int A, B, a, b, HCF, LCM;
                Console.Write("Enter A:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter b:");
                B = Convert.ToInt32(Console.ReadLine());
                a = A;
                b = B;
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                HCF = a;
                LCM = (A * B) / HCF;
                Console.WriteLine("HCF:{0}\nLCM{1}", HCF, LCM);

            }
            catch
            {
                Console.WriteLine("Your input is wrong");
            }
        }
    }
}
