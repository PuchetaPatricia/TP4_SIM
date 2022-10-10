using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM_GA.Entities;
using TP4_SIM_GA.Helpers;

namespace TP4_SIM_GA.BackEnd
{
    public static class Processes
    {
        public static double ExponentialMethod(double media, Results result)
        {
            double lambda = 1/media;
            double rnd;
            double x;
            Random random = new Random();
            rnd = random.NextDouble();
            x = (-1 / lambda) * Math.Log(1 - rnd);

            return MathHelper.TruncateDigits(x, 4);
        }

        public static double UniformeMethod(double a,double b, Results result)
        {
            double rnd;
            double x;
            Random random = new Random();
            rnd = random.NextDouble();
            x = a + rnd*(b-a);

            return MathHelper.TruncateDigits(x, 4);
        }
    }
}
