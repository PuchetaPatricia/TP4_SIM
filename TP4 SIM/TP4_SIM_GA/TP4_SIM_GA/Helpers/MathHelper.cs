using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM_GA.Helpers
{
    internal static class MathHelper
    {
        public static double TruncateDigits(double value, int precission)
        {
            var multiplier = (double)Math.Pow(10, precission);
            return Math.Truncate(value * multiplier) / multiplier;
        }
    }
}
