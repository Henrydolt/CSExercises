using System;

namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            int a = i / 16;
            int b = i % 16;

            string c = "";
            if (b < 10)
                c = Convert.ToString(b);
            else
                switch (b)
                {
                    case 10:
                        c = "A";
                        break;
                    case 11:
                        c = "B";
                        break;
                    case 12:
                        c = "C";
                        break;
                    case 13:
                        c = "D";
                        break;
                    case 14:
                        c = "E";
                        break;
                    case 15:
                        c = "F";
                        break;
                    default:
                        break;

                }
            c = Convert.ToString(a) + c;

            return c;
        }
    }
}
