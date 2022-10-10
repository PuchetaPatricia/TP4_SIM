using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM_GA.Entities
{
    public class Fila
    {
        public double MinValue { get; set; } = 0;

        public double MaxValue { get; set; } = 0;

        public double ObservedFrecuency { get; set; } = 0;

        public double ExpectedFrecuency { get; set; } = 0;

        public double TestStadistic { get; set; } = 0;

        public double Acum { get; set; } = 0;

        public double ClassMark { get; set; }
    }
}
