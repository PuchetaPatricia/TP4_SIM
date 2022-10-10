using TP4_SIM_GA.BackEnd;
using TP4_SIM_GA.Entities;
using TP4_SIM_GA.Helpers;

namespace TP4_SIM_GA
{
    public partial class GeneradorMontecarlo : Form
    {
        public GeneradorMontecarlo()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {            
            if(txtSimulaciones.Text.Equals("") || int.Parse(txtSimulaciones.Text) <= 0)
            {
                MessageBox.Show("ingrese un valor mayor a 0");
                return;
            }
            int simulaciones = int.Parse(txtSimulaciones.Text);
            Results result = GenerateResults.generate(simulaciones);
            LoadSerieTable(result);
            LoadTableVectoresEstado(result);
            LoadHistogram(HistogramHelper.GenerateHistogramPng(simulaciones, result));
            txtProbabilidad.Text = probabilidad45DiasOMenos(result, simulaciones).ToString();
        }

        private void LoadSerieTable(Results result)
        {
            dgvSerie.Rows.Clear();
            BindingSource bindingSource = new BindingSource
            {
                DataSource = result.Serie.Select(x => new { Serie = x }).ToList()
            };
            dgvSerie.DataSource = bindingSource;
            dgvSerie.RowHeadersVisible = false;
        }

        private void LoadTableVectoresEstado(Results result)
        {
            dgvVectoresEstado.DataSource = result.tablaVectorEstado.Select(x => new
            {
                Simulacion = x.nroSimulacion,
                Tiempo1 = x.t1,
                Tiempo2 = x.t2,
                Tiempo3 = x.t3,
                Tiempo4 = x.t4,
                Tiempo5 = x.t5,
                DuracionEnsamble = x.tiempoEnsamble,
                Maximo = x.max,
                Minimo = x.min,
                Acumulador = x.acumulador,
                Promedio = x.promedio,
                MenorIgual45 = x.menorIgual45
            }).ToList();            
            dgvVectoresEstado.RowHeadersVisible=false;
        }

        private void LoadHistogram(string path)
        {
            pictureBoxHistograma.Image = Image.FromFile(path);
        }

        private double probabilidad45DiasOMenos(Results result, int simul)
        {
            double cantidad = 0;
            if (simul == 1)
            {
                cantidad = result.tablaVectorEstado[0].menorIgual45;

            }
            else
            {
                cantidad = result.tablaVectorEstado[1].menorIgual45;
            }
            return cantidad / simul;
        }
    }
}