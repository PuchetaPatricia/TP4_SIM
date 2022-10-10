using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM_GA.Entities
{
    public class Results
    {
        public List<double> Serie { get; set; } = new List<double>();

        public List<VectorEstado> tablaVectorEstado { get; set; } = new List<VectorEstado>();

        public List<double> promedios { get; set; } = new List<double>();
    }
}
