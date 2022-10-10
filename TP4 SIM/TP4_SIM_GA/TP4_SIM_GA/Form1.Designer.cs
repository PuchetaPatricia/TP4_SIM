namespace TP4_SIM_GA
{
    partial class GeneradorMontecarlo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSimulaciones = new System.Windows.Forms.MaskedTextBox();
            this.dgvVectoresEstado = new System.Windows.Forms.DataGridView();
            this.dgvSerie = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxHistograma = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.dgvFrecuenciasA = new System.Windows.Forms.DataGridView();
            this.dgvFrecuenciasB = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasA = new System.Windows.Forms.TextBox();
            this.txtDiasB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVectoresEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciasA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciasB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Simulaciones:";
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Location = new System.Drawing.Point(175, 17);
            this.txtSimulaciones.Mask = "9999999";
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(100, 23);
            this.txtSimulaciones.TabIndex = 1;
            this.txtSimulaciones.ValidatingType = typeof(int);
            // 
            // dgvVectoresEstado
            // 
            this.dgvVectoresEstado.AllowUserToAddRows = false;
            this.dgvVectoresEstado.AllowUserToDeleteRows = false;
            this.dgvVectoresEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVectoresEstado.Location = new System.Drawing.Point(12, 67);
            this.dgvVectoresEstado.Name = "dgvVectoresEstado";
            this.dgvVectoresEstado.ReadOnly = true;
            this.dgvVectoresEstado.RowTemplate.Height = 25;
            this.dgvVectoresEstado.Size = new System.Drawing.Size(1035, 102);
            this.dgvVectoresEstado.TabIndex = 2;
            // 
            // dgvSerie
            // 
            this.dgvSerie.AllowUserToAddRows = false;
            this.dgvSerie.AllowUserToDeleteRows = false;
            this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerie.Location = new System.Drawing.Point(1074, 25);
            this.dgvSerie.Name = "dgvSerie";
            this.dgvSerie.ReadOnly = true;
            this.dgvSerie.RowHeadersVisible = false;
            this.dgvSerie.RowTemplate.Height = 25;
            this.dgvSerie.Size = new System.Drawing.Size(91, 457);
            this.dgvSerie.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(299, 16);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1102, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Histograma";
            // 
            // pictureBoxHistograma
            // 
            this.pictureBoxHistograma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxHistograma.Location = new System.Drawing.Point(201, 190);
            this.pictureBoxHistograma.Name = "pictureBoxHistograma";
            this.pictureBoxHistograma.Size = new System.Drawing.Size(846, 294);
            this.pictureBoxHistograma.TabIndex = 8;
            this.pictureBoxHistograma.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "P(45 dias o menos):";
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Location = new System.Drawing.Point(42, 206);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(110, 23);
            this.txtProbabilidad.TabIndex = 10;
            // 
            // dgvFrecuenciasA
            // 
            this.dgvFrecuenciasA.AllowUserToAddRows = false;
            this.dgvFrecuenciasA.AllowUserToDeleteRows = false;
            this.dgvFrecuenciasA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuenciasA.Location = new System.Drawing.Point(12, 524);
            this.dgvFrecuenciasA.Name = "dgvFrecuenciasA";
            this.dgvFrecuenciasA.ReadOnly = true;
            this.dgvFrecuenciasA.RowTemplate.Height = 25;
            this.dgvFrecuenciasA.Size = new System.Drawing.Size(424, 298);
            this.dgvFrecuenciasA.TabIndex = 11;
            // 
            // dgvFrecuenciasB
            // 
            this.dgvFrecuenciasB.AllowUserToAddRows = false;
            this.dgvFrecuenciasB.AllowUserToDeleteRows = false;
            this.dgvFrecuenciasB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuenciasB.Location = new System.Drawing.Point(628, 524);
            this.dgvFrecuenciasB.Name = "dgvFrecuenciasB";
            this.dgvFrecuenciasB.ReadOnly = true;
            this.dgvFrecuenciasB.RowTemplate.Height = 25;
            this.dgvFrecuenciasB.Size = new System.Drawing.Size(380, 298);
            this.dgvFrecuenciasB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tabla De Frecuencias Punto a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tabla De Frecuencias Punto b";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 60);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha a fijar si se busca una\r\nconfianza del 90%  de terminar\r\nen esa fecha o ant" +
    "es\r\nsobre el total de las simulaciones";
            // 
            // txtDiasA
            // 
            this.txtDiasA.Location = new System.Drawing.Point(458, 606);
            this.txtDiasA.Name = "txtDiasA";
            this.txtDiasA.ReadOnly = true;
            this.txtDiasA.Size = new System.Drawing.Size(100, 23);
            this.txtDiasA.TabIndex = 16;
            // 
            // txtDiasB
            // 
            this.txtDiasB.Location = new System.Drawing.Point(1034, 606);
            this.txtDiasB.Name = "txtDiasB";
            this.txtDiasB.ReadOnly = true;
            this.txtDiasB.Size = new System.Drawing.Size(100, 23);
            this.txtDiasB.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1014, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 60);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha a fijar si se busca una\r\nconfianza del 90%  de terminar\r\nen esa fecha o ant" +
    "es\r\nsobre las primeras 14 simulaciones";
            // 
            // GeneradorMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 824);
            this.Controls.Add(this.txtDiasB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiasA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvFrecuenciasB);
            this.Controls.Add(this.dgvFrecuenciasA);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxHistograma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvSerie);
            this.Controls.Add(this.dgvVectoresEstado);
            this.Controls.Add(this.txtSimulaciones);
            this.Controls.Add(this.label1);
            this.Name = "GeneradorMontecarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVectoresEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciasA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuenciasB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox txtSimulaciones;
        private DataGridView dgvVectoresEstado;
        private DataGridView dgvSerie;
        private Button btnGenerar;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxHistograma;
        private Label label5;
        private TextBox txtProbabilidad;
        private DataGridView dgvFrecuenciasA;
        private DataGridView dgvFrecuenciasB;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDiasA;
        private TextBox txtDiasB;
        private Label label9;
    }
}