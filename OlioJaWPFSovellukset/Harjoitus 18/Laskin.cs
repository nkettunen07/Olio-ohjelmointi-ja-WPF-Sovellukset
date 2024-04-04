using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_18
{
    public class Laskin
    {
        // Laskin.Summa(x, x) = x + x
        public static float Summa(float a, float b)
        {
            return a + b;
        }
        // Laskin.Erotus(x, x) = x - x
        public static float Erotus(float a, float b)
        {
            return a - b;
        }
        // Laskin.Kertolasku(x, x) = x * x
        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }
        // Laskin.Jako(x, x) = x / x
        public static float Jako(float a, float b)
        {
            return a / b;
        }
        // Aika simppeleitä.
    }
}
