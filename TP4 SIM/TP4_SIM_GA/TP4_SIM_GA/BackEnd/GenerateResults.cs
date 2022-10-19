using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM_GA.Entities;
using TP4_SIM_GA.Helpers;

namespace TP4_SIM_GA.BackEnd
{
    public static class GenerateResults
    {
        public static Results generate(int cantSim)
        {
            Results result = new Results();
            for (int i = 0; i < cantSim; i++)
            {
                double menor45 = 0;
                int nro = i + 1;
                double t1 = MathHelper.TruncateDigits(Processes.UniformeMethod(20, 30, result),4);
                double t2 = MathHelper.TruncateDigits(Processes.UniformeMethod(30, 50, result),4);
                double t3 = MathHelper.TruncateDigits(Processes.ExponentialMethod(30, result),4);
                double t4 = MathHelper.TruncateDigits(Processes.UniformeMethod(10, 20, result) + t1,4);
                double t5 = MathHelper.TruncateDigits(Processes.ExponentialMethod(5, result) + Math.Max(t2, t4),4);
                double duracion = MathHelper.TruncateDigits(Math.Max(t3, t5), 4);
                result.Serie.Add(duracion);
                double maximo = result.Serie.Max();
                double minimo = result.Serie.Min();
                double acum = 0;
                if (i==0)
                {
                    acum = duracion;
                    double prom = MathHelper.TruncateDigits(acum / nro,4);
                    if (duracion <= 45)
                    {
                        menor45++;
                    }
                    VectorEstado vec = new VectorEstado(nro, t1, t2, t3, t4, t5, duracion, maximo, minimo, acum, prom, menor45);
                    result.tablaVectorEstado.Add(vec);
                    result.promedios.Add(prom);
                }
                else
                {
                    if (i == 1)
                    {
                        menor45 = result.tablaVectorEstado[0].menorIgual45;
                        acum = MathHelper.TruncateDigits(duracion + result.tablaVectorEstado[0].acumulador, 4);
                    }
                    else
                    {
                        menor45 = result.tablaVectorEstado[1].menorIgual45;
                        acum = MathHelper.TruncateDigits(duracion + result.tablaVectorEstado[1].acumulador, 4);
                    }
                    
                    double prom = MathHelper.TruncateDigits(acum / nro,4);
                    if (duracion <= 45)
                    {
                        menor45++;
                    }
                    result.promedios.Add(prom);
                    VectorEstado vec = new VectorEstado(nro, t1, t2, t3, t4, t5, duracion, maximo, minimo, acum, prom, menor45);
                    if (i == 1)
                    {
                        result.tablaVectorEstado.Add(vec);
                        
                    }
                    else
                    {
                        result.tablaVectorEstado[0] = result.tablaVectorEstado[1];
                        result.tablaVectorEstado[1] = vec;
                    }

                }

            }

            result.GenerateTable(cantSim);
            for (int i = 0; i < cantSim; i++)
            {
                AddObservedFrecuencyA(result.Serie[i], result);
                if (i < 14)
                {
                    AddObservedFrecuencyB(result.Serie[i], result);
                }
            }

            double noventa = cantSim * 0.9;
            result.noventa = noventa;
            CalcularAcum(result);
            return result;
        }

        //Por cada observacion del random generado agrega uno a la FO de la fila que corresponde
        private static void AddObservedFrecuencyA(double nro, Results result)
        {
            for (int i = 0; i < 15; i++)
            {
                if ((nro >= result.TablaA[i].MinValue && nro <= result.TablaA[i].MaxValue) || i == 14)
                {
                    result.TablaA[i].ObservedFrecuency++;
                    break;
                }   
            }
        }

        private static void AddObservedFrecuencyB(double nro, Results result)
        {
            for (int i = 0; i < 15; i++)
            {
                if ((nro >= result.TablaB[i].MinValue && nro <= result.TablaB[i].MaxValue) || i == 14)
                {
                    result.TablaB[i].ObservedFrecuency++;
                    break;
                }
            }
        }

        private static void CalcularAcum( Results result)
        {
            double acumA = result.TablaA[0].ObservedFrecuency;
            double acumB = result.TablaB[0].ObservedFrecuency;
            bool banA = false;
            bool banB = false;
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    acumA = result.TablaA[i].ObservedFrecuency;
                    acumB = result.TablaB[i].ObservedFrecuency;
                }
                else
                {
                    acumA = result.TablaA[i].ObservedFrecuency + result.TablaA[i - 1].Acum;
                    acumB = result.TablaB[i].ObservedFrecuency + result.TablaB[i - 1].Acum;
                }
                result.TablaA[i].Acum = acumA;
                result.TablaB[i].Acum = acumB;

                if (acumA >= result.noventa && banA == false)
                {
                    banA = true;
                    result.fechaAFijarA = result.TablaA[i].MaxValue;
                }
                if (acumB >= result.primeras14 && banB == false)
                {
                    banB = true;
                    result.fechaAFijarB = result.TablaB[i].MaxValue;
                }
            }
        }

    }
}
