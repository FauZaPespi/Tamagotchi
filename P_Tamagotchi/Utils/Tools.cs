using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Utils
{
    public class Tools
    {
        public static int LimitInclusive(int value, int min, int max)
        {
            return Math.Min(max, Math.Max(value, min));
        }
    }
}
