using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();//the number you need
            try
            {
                int TV, DVD, MP3;
                Console.Write("Enter quantify for TV($):");
                TV = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter quantify for DVD($):");
                DVD = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter quantify for MP3($):");
                MP3 = Convert.ToInt32(Console.ReadLine());
                if (900 * TV + 500 * DVD + 700 * MP3> 10000)
                    Console.WriteLine("Total price for this order is ${0}", ((900 * TV + 500 * DVD) * 0.85 + 700 * MP3));
                else if (900 * TV + 500 * DVD + 700 * MP3> 5000)
                    Console.WriteLine("Total price for this order is ${0}", ((900 * TV + 500 * DVD) * 0.9 + 700 * MP3));
                else 
                    Console.WriteLine("Total price for this order is ${0}", (900 * TV + 500 * DVD + 700 * MP3));
            }
            catch
            {
                Console.WriteLine("Your input is wrong.");
            }
        }
    }
}