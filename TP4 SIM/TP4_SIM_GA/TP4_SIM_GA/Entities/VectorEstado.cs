using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_SIM_GA.Entities
{
    public class VectorEstado
    {
        public int nroSimulacion { get; set; }
        public double t1 { get; set; }
        public double t2 { get; set; }
        public double t3 { get; set; }
        public double t4 { get; set; }
        public double t5 { get; set; }
        public double tiempoEnsamble { get; set; }
        public double max { get; set; }
        public double min { get; set; }
        public double acumulador { get; set; }
        public double promedio { get; set; }
        public double menorIgual45 { get; set; }

        public VectorEstado(int nro,double t1, double t2, double t3, double t4, double t5, double tiempo, double max, double min, double acum, double prom, double menor45)
        {
            this.nroSimulacion = nro;
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;
            this.tiempoEnsamble = tiempo;
            this.max = max;
            this.min = min;
            this.acumulador = acum;
            this.promedio = prom;
            this.menorIgual45 = menor45;
        }
    }
}
