using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM_GA.Helpers;

namespace TP4_SIM_GA.Entities
{
    public class Results
    {
        public List<double> Serie { get; set; } = new List<double>();

        public List<VectorEstado> tablaVectorEstado { get; set; } = new List<VectorEstado>();

        public List<double> promedios { get; set; } = new List<double>();

        public List<Fila> TablaA { get; set; } = new List<Fila>();
        public List<Fila> TablaB { get; set; } = new List<Fila>();

        public double primeras14 { get; set; } = 13;
        public double noventa { get; set; } = 0;

        public double fechaAFijarA { get; set; } = 0;
        public double fechaAFijarB { get; set; } = 0;

        //Creamos la plantilla vacia de la tabla, para despues rellenarla
        public void GenerateTable(int cant)
        {
            GenerateTableA(cant);
            GenerateTableB(cant);
        }

        public void GenerateTableA(int cant)
        {
            double max = Serie.Max();
            double min = Serie.Min();
            double rango = max - min;
            //Amplitud, rango de cada intervalo
            double intervalRange = rango / 15;
            double actualRange = min + intervalRange;
            //Frecuencia esperada
            int expectedFreq = cant / 15;
            //Aca se generan los intervalos de cada fila de la tabla 
            for (var i = 0; i < 15; i++)
            {
                Fila row = new Fila
                {
                    MinValue = MathHelper.TruncateDigits(actualRange - intervalRange, 4),
                    MaxValue = MathHelper.TruncateDigits(actualRange - 0.0001, 4),
                    ExpectedFrecuency = MathHelper.TruncateDigits(expectedFreq, 4),
                    ClassMark = intervalRange / 2
                };
                actualRange += intervalRange;
                this.TablaA.Add(row);
            }
        }

        public void GenerateTableB(int cant)
        {
            double max = Serie[0];
            double min = Serie[0];
            for (int i = 0; i < 14; i++)
            {
                if (Serie[i] > max)
                {
                    max = Serie[i];
                }
                else if (Serie[i] < min)
                {
                    min = Serie[i];
                }
            }
            double rango = max - min;
            //Amplitud, rango de cada intervalo
            double intervalRange = rango / 15;
            double actualRange = min + intervalRange;
            //Frecuencia esperada
            int expectedFreq = cant / 15;
            //Aca se generan los intervalos de cada fila de la tabla 
            for (var i = 0; i < 15; i++)
            {
                Fila row = new Fila
                {
                    MinValue = MathHelper.TruncateDigits(actualRange - intervalRange, 4),
                    MaxValue = MathHelper.TruncateDigits(actualRange - 0.0001, 4),
                    ExpectedFrecuency = MathHelper.TruncateDigits(expectedFreq, 4),
                    ClassMark = intervalRange / 2
                };
                actualRange += intervalRange;
                this.TablaB.Add(row);
            }
        }
    }
}
