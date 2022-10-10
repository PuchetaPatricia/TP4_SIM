using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_SIM_GA.Entities;

namespace TP4_SIM_GA.Helpers
{
    public static class HistogramHelper
    {
        static ScottPlot.Plot plt;
        public static string GenerateHistogramPng(int cant, Results result)
        {
            plt = new ScottPlot.Plot(745, 326); //Size of PictureBox
            (double[] values, double[] binEdges) = SetValues(cant, result);
            SetBars(result, binEdges, values);
            SetScatterLine(binEdges, values);
            StylePlot(result);
            return SaveFile();
        }

        private static (double[], double[]) SetValues(int cant, Results result)
        {
            double[] values = new double[result.promedios.Count];
            double[] binEdges = new double[result.promedios.Count];
            for (var i = 0; i < result.promedios.Count; i++)
            {
                values[i] = result.promedios[i];
                binEdges[i] = i+1;
            }
            return (values, binEdges);
        }

        private static void SetBars(Results result, double[] binEdges, double[] values)
        {
            var bar = plt.AddBar(values: values, positions: binEdges);
            bar.BarWidth = (result.promedios.Max() - result.promedios.Min() / result.promedios.Count);
            bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
            bar.BorderColor = ColorTranslator.FromHtml("#82add9");
        }

        private static void SetScatterLine(double[] binEdges, double[] values)
        {
            plt.AddScatterLines(
                xs: binEdges,
                ys: values,
                color: Color.Black,
                lineWidth: 2,
                lineStyle: ScottPlot.LineStyle.Dash);
        }

        private static void StylePlot(Results result)
        {
            plt.Title("Histograma de evolucion del tiempo promedio de duracion del ensamble");
            plt.YAxis.Label("Promedio");
            plt.XAxis.Label("Simulacion");
            plt.SetAxisLimits(xMin: 0, yMin: 0);
            plt.AxisAuto();
            //plt.Margins(0, 0);
        }

        private static string SaveFile()
        {
            string date = DateTime.Now.ToString("ddMMyyyyhhmmss");
            string filePath = $"./histogram{date}.png";
            plt.SaveFig(filePath);
            return filePath;
        }
    }
}
