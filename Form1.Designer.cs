namespace AnalisidiDatiAmbientali_Sacchiero_Baldo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_luogo = new System.Windows.Forms.Button();
            this.txt_luogo = new System.Windows.Forms.TextBox();
            this.pnl_luogo = new System.Windows.Forms.Panel();
            this.pnl_dati = new System.Windows.Forms.Panel();
            this.tbc_dati = new System.Windows.Forms.TabControl();
            this.tbp_home = new System.Windows.Forms.TabPage();
            this.btn_mem = new System.Windows.Forms.Button();
            this.btn_dati = new System.Windows.Forms.Button();
            this.tbp_grafici = new System.Windows.Forms.TabPage();
            this.tbp_analisi = new System.Windows.Forms.TabPage();
            this.lbl_correlazione = new System.Windows.Forms.Label();
            this.lbl_statistiche = new System.Windows.Forms.Label();
            this.dtg_analisi = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_luogo.SuspendLayout();
            this.pnl_dati.SuspendLayout();
            this.tbc_dati.SuspendLayout();
            this.tbp_home.SuspendLayout();
            this.tbp_grafici.SuspendLayout();
            this.tbp_analisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luogo
            // 
            this.btn_luogo.Location = new System.Drawing.Point(506, 55);
            this.btn_luogo.Name = "btn_luogo";
            this.btn_luogo.Size = new System.Drawing.Size(75, 23);
            this.btn_luogo.TabIndex = 1;
            this.btn_luogo.Text = "inizia";
            this.btn_luogo.UseVisualStyleBackColor = true;
            this.btn_luogo.Click += new System.EventHandler(this.btn_luogo_Click);
            // 
            // txt_luogo
            // 
            this.txt_luogo.Location = new System.Drawing.Point(493, 16);
            this.txt_luogo.Name = "txt_luogo";
            this.txt_luogo.Size = new System.Drawing.Size(100, 20);
            this.txt_luogo.TabIndex = 3;
            // 
            // pnl_luogo
            // 
            this.pnl_luogo.Controls.Add(this.txt_luogo);
            this.pnl_luogo.Controls.Add(this.btn_luogo);
            this.pnl_luogo.Location = new System.Drawing.Point(12, 304);
            this.pnl_luogo.Name = "pnl_luogo";
            this.pnl_luogo.Size = new System.Drawing.Size(1086, 104);
            this.pnl_luogo.TabIndex = 4;
            // 
            // pnl_dati
            // 
            this.pnl_dati.Controls.Add(this.tbc_dati);
            this.pnl_dati.Location = new System.Drawing.Point(15, 12);
            this.pnl_dati.Name = "pnl_dati";
            this.pnl_dati.Size = new System.Drawing.Size(1080, 650);
            this.pnl_dati.TabIndex = 5;
            // 
            // tbc_dati
            // 
            this.tbc_dati.Controls.Add(this.tbp_home);
            this.tbc_dati.Controls.Add(this.tbp_grafici);
            this.tbc_dati.Controls.Add(this.tbp_analisi);
            this.tbc_dati.Location = new System.Drawing.Point(3, 3);
            this.tbc_dati.Name = "tbc_dati";
            this.tbc_dati.SelectedIndex = 0;
            this.tbc_dati.Size = new System.Drawing.Size(1074, 644);
            this.tbc_dati.TabIndex = 3;
            // 
            // tbp_home
            // 
            this.tbp_home.Controls.Add(this.btn_mem);
            this.tbp_home.Controls.Add(this.btn_dati);
            this.tbp_home.Location = new System.Drawing.Point(4, 22);
            this.tbp_home.Name = "tbp_home";
            this.tbp_home.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_home.Size = new System.Drawing.Size(1066, 618);
            this.tbp_home.TabIndex = 0;
            this.tbp_home.Text = "Home";
            this.tbp_home.UseVisualStyleBackColor = true;
            // 
            // btn_mem
            // 
            this.btn_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mem.Location = new System.Drawing.Point(473, 329);
            this.btn_mem.Name = "btn_mem";
            this.btn_mem.Size = new System.Drawing.Size(120, 44);
            this.btn_mem.TabIndex = 3;
            this.btn_mem.Text = "salva";
            this.btn_mem.UseVisualStyleBackColor = true;
            this.btn_mem.Click += new System.EventHandler(this.btn_mem_Click);
            // 
            // btn_dati
            // 
            this.btn_dati.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dati.Location = new System.Drawing.Point(473, 245);
            this.btn_dati.Name = "btn_dati";
            this.btn_dati.Size = new System.Drawing.Size(120, 44);
            this.btn_dati.TabIndex = 2;
            this.btn_dati.Text = "raccogli";
            this.btn_dati.UseVisualStyleBackColor = true;
            this.btn_dati.Click += new System.EventHandler(this.btn_dati_Click);
            // 
            // tbp_grafici
            // 
            this.tbp_grafici.Controls.Add(this.chart1);
            this.tbp_grafici.Location = new System.Drawing.Point(4, 22);
            this.tbp_grafici.Name = "tbp_grafici";
            this.tbp_grafici.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_grafici.Size = new System.Drawing.Size(1066, 618);
            this.tbp_grafici.TabIndex = 1;
            this.tbp_grafici.Text = "Grafici";
            this.tbp_grafici.UseVisualStyleBackColor = true;
            // 
            // tbp_analisi
            // 
            this.tbp_analisi.Controls.Add(this.lbl_correlazione);
            this.tbp_analisi.Controls.Add(this.lbl_statistiche);
            this.tbp_analisi.Controls.Add(this.dtg_analisi);
            this.tbp_analisi.Location = new System.Drawing.Point(4, 22);
            this.tbp_analisi.Name = "tbp_analisi";
            this.tbp_analisi.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_analisi.Size = new System.Drawing.Size(1066, 618);
            this.tbp_analisi.TabIndex = 2;
            this.tbp_analisi.Text = "analisi";
            this.tbp_analisi.UseVisualStyleBackColor = true;
            // 
            // lbl_correlazione
            // 
            this.lbl_correlazione.AutoSize = true;
            this.lbl_correlazione.Location = new System.Drawing.Point(229, 6);
            this.lbl_correlazione.Name = "lbl_correlazione";
            this.lbl_correlazione.Size = new System.Drawing.Size(64, 13);
            this.lbl_correlazione.TabIndex = 3;
            this.lbl_correlazione.Text = "correlazione";
            // 
            // lbl_statistiche
            // 
            this.lbl_statistiche.AutoSize = true;
            this.lbl_statistiche.Location = new System.Drawing.Point(6, 3);
            this.lbl_statistiche.Name = "lbl_statistiche";
            this.lbl_statistiche.Size = new System.Drawing.Size(54, 13);
            this.lbl_statistiche.TabIndex = 2;
            this.lbl_statistiche.Text = "statistiche";
            // 
            // dtg_analisi
            // 
            this.dtg_analisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_analisi.Location = new System.Drawing.Point(483, 6);
            this.dtg_analisi.Name = "dtg_analisi";
            this.dtg_analisi.Size = new System.Drawing.Size(577, 606);
            this.dtg_analisi.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1054, 606);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 674);
            this.Controls.Add(this.pnl_dati);
            this.Controls.Add(this.pnl_luogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_luogo.ResumeLayout(false);
            this.pnl_luogo.PerformLayout();
            this.pnl_dati.ResumeLayout(false);
            this.tbc_dati.ResumeLayout(false);
            this.tbp_home.ResumeLayout(false);
            this.tbp_grafici.ResumeLayout(false);
            this.tbp_analisi.ResumeLayout(false);
            this.tbp_analisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_luogo;
        private System.Windows.Forms.TextBox txt_luogo;
        private System.Windows.Forms.Panel pnl_luogo;
        private System.Windows.Forms.Panel pnl_dati;
        private System.Windows.Forms.Button btn_dati;
        private System.Windows.Forms.TabControl tbc_dati;
        private System.Windows.Forms.TabPage tbp_home;
        private System.Windows.Forms.TabPage tbp_grafici;
        private System.Windows.Forms.Button btn_mem;
        private System.Windows.Forms.TabPage tbp_analisi;
        private System.Windows.Forms.DataGridView dtg_analisi;
        private System.Windows.Forms.Label lbl_correlazione;
        private System.Windows.Forms.Label lbl_statistiche;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

