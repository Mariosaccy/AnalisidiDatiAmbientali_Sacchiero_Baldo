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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_luogo = new System.Windows.Forms.Button();
            this.txt_luogo = new System.Windows.Forms.TextBox();
            this.pnl_luogo = new System.Windows.Forms.Panel();
            this.lbl_titoloLuogo = new System.Windows.Forms.Label();
            this.pnl_dati = new System.Windows.Forms.Panel();
            this.tbc_dati = new System.Windows.Forms.TabControl();
            this.tbp_home = new System.Windows.Forms.TabPage();
            this.lbl_orario = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_dati = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_dataOdierna = new System.Windows.Forms.Label();
            this.tbp_grafici = new System.Windows.Forms.TabPage();
            this.chr_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbp_analisi = new System.Windows.Forms.TabPage();
            this.lbl_correlazione = new System.Windows.Forms.Label();
            this.lbl_statistiche = new System.Windows.Forms.Label();
            this.dtg_analisi = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_datiAuto = new System.Windows.Forms.Button();
            this.tmr_raccoltaDatiAuto = new System.Windows.Forms.Timer(this.components);
            this.pnl_luogo.SuspendLayout();
            this.pnl_dati.SuspendLayout();
            this.tbc_dati.SuspendLayout();
            this.tbp_home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbp_grafici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chr_grafico)).BeginInit();
            this.tbp_analisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luogo
            // 
            this.btn_luogo.Location = new System.Drawing.Point(557, 111);
            this.btn_luogo.Name = "btn_luogo";
            this.btn_luogo.Size = new System.Drawing.Size(75, 23);
            this.btn_luogo.TabIndex = 1;
            this.btn_luogo.Text = "INVIA";
            this.btn_luogo.UseVisualStyleBackColor = true;
            this.btn_luogo.Click += new System.EventHandler(this.btn_luogo_Click);
            // 
            // txt_luogo
            // 
            this.txt_luogo.Location = new System.Drawing.Point(544, 72);
            this.txt_luogo.Name = "txt_luogo";
            this.txt_luogo.Size = new System.Drawing.Size(100, 20);
            this.txt_luogo.TabIndex = 3;
            // 
            // pnl_luogo
            // 
            this.pnl_luogo.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_luogo.Controls.Add(this.lbl_titoloLuogo);
            this.pnl_luogo.Controls.Add(this.txt_luogo);
            this.pnl_luogo.Controls.Add(this.btn_luogo);
            this.pnl_luogo.Location = new System.Drawing.Point(-27, 249);
            this.pnl_luogo.Name = "pnl_luogo";
            this.pnl_luogo.Size = new System.Drawing.Size(1273, 176);
            this.pnl_luogo.TabIndex = 4;
            // 
            // lbl_titoloLuogo
            // 
            this.lbl_titoloLuogo.AutoSize = true;
            this.lbl_titoloLuogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloLuogo.Location = new System.Drawing.Point(484, 29);
            this.lbl_titoloLuogo.Name = "lbl_titoloLuogo";
            this.lbl_titoloLuogo.Size = new System.Drawing.Size(248, 25);
            this.lbl_titoloLuogo.TabIndex = 4;
            this.lbl_titoloLuogo.Text = "INSERIRE NOME CITTA\'";
            // 
            // pnl_dati
            // 
            this.pnl_dati.Controls.Add(this.tbc_dati);
            this.pnl_dati.Location = new System.Drawing.Point(13, 9);
            this.pnl_dati.Name = "pnl_dati";
            this.pnl_dati.Size = new System.Drawing.Size(1186, 657);
            this.pnl_dati.TabIndex = 5;
            // 
            // tbc_dati
            // 
            this.tbc_dati.Controls.Add(this.tbp_home);
            this.tbc_dati.Controls.Add(this.tbp_grafici);
            this.tbc_dati.Controls.Add(this.tbp_analisi);
            this.tbc_dati.Location = new System.Drawing.Point(14, 6);
            this.tbc_dati.Name = "tbc_dati";
            this.tbc_dati.SelectedIndex = 0;
            this.tbc_dati.Size = new System.Drawing.Size(1158, 644);
            this.tbc_dati.TabIndex = 3;
            // 
            // tbp_home
            // 
            this.tbp_home.BackColor = System.Drawing.Color.Bisque;
            this.tbp_home.Controls.Add(this.lbl_orario);
            this.tbp_home.Controls.Add(this.btn_dati);
            this.tbp_home.Controls.Add(this.panel1);
            this.tbp_home.Controls.Add(this.panel2);
            this.tbp_home.Location = new System.Drawing.Point(4, 22);
            this.tbp_home.Name = "tbp_home";
            this.tbp_home.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbp_home.Size = new System.Drawing.Size(1150, 618);
            this.tbp_home.TabIndex = 0;
            this.tbp_home.Text = "Home";
            // 
            // lbl_orario
            // 
            this.lbl_orario.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_orario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orario.Location = new System.Drawing.Point(410, 98);
            this.lbl_orario.Name = "lbl_orario";
            this.lbl_orario.Size = new System.Drawing.Size(355, 54);
            this.lbl_orario.TabIndex = 5;
            this.lbl_orario.Text = "orario";
            this.lbl_orario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(10, 249);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(345, 44);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "PULISCI DATI";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_dati
            // 
            this.btn_dati.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dati.Location = new System.Drawing.Point(410, 200);
            this.btn_dati.Name = "btn_dati";
            this.btn_dati.Size = new System.Drawing.Size(345, 44);
            this.btn_dati.TabIndex = 2;
            this.btn_dati.Text = "RACCOGLI DATI ORA";
            this.btn_dati.UseVisualStyleBackColor = true;
            this.btn_dati.Click += new System.EventHandler(this.btn_dati_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.btn_datiAuto);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_mem);
            this.panel1.Location = new System.Drawing.Point(400, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 305);
            this.panel1.TabIndex = 7;
            // 
            // btn_mem
            // 
            this.btn_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mem.Location = new System.Drawing.Point(10, 176);
            this.btn_mem.Name = "btn_mem";
            this.btn_mem.Size = new System.Drawing.Size(345, 44);
            this.btn_mem.TabIndex = 3;
            this.btn_mem.Text = "SALVA DATI IN UN FILE";
            this.btn_mem.UseVisualStyleBackColor = true;
            this.btn_mem.Click += new System.EventHandler(this.btn_mem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.lbl_dataOdierna);
            this.panel2.Location = new System.Drawing.Point(400, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 117);
            this.panel2.TabIndex = 8;
            // 
            // lbl_dataOdierna
            // 
            this.lbl_dataOdierna.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataOdierna.Location = new System.Drawing.Point(3, 9);
            this.lbl_dataOdierna.Name = "lbl_dataOdierna";
            this.lbl_dataOdierna.Size = new System.Drawing.Size(362, 54);
            this.lbl_dataOdierna.TabIndex = 6;
            this.lbl_dataOdierna.Text = "data";
            this.lbl_dataOdierna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbp_grafici
            // 
            this.tbp_grafici.Controls.Add(this.chr_grafico);
            this.tbp_grafici.Location = new System.Drawing.Point(4, 22);
            this.tbp_grafici.Name = "tbp_grafici";
            this.tbp_grafici.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbp_grafici.Size = new System.Drawing.Size(1150, 618);
            this.tbp_grafici.TabIndex = 1;
            this.tbp_grafici.Text = "Grafici";
            this.tbp_grafici.UseVisualStyleBackColor = true;
            // 
            // chr_grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chr_grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr_grafico.Legends.Add(legend1);
            this.chr_grafico.Location = new System.Drawing.Point(6, 6);
            this.chr_grafico.Name = "chr_grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr_grafico.Series.Add(series1);
            this.chr_grafico.Size = new System.Drawing.Size(1054, 606);
            this.chr_grafico.TabIndex = 0;
            this.chr_grafico.Text = "chart1";
            // 
            // tbp_analisi
            // 
            this.tbp_analisi.Controls.Add(this.lbl_correlazione);
            this.tbp_analisi.Controls.Add(this.lbl_statistiche);
            this.tbp_analisi.Controls.Add(this.dtg_analisi);
            this.tbp_analisi.Location = new System.Drawing.Point(4, 22);
            this.tbp_analisi.Name = "tbp_analisi";
            this.tbp_analisi.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbp_analisi.Size = new System.Drawing.Size(1150, 618);
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
            this.dtg_analisi.Location = new System.Drawing.Point(485, 6);
            this.dtg_analisi.Name = "dtg_analisi";
            this.dtg_analisi.RowHeadersWidth = 51;
            this.dtg_analisi.Size = new System.Drawing.Size(655, 606);
            this.dtg_analisi.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "ANALISI DATI AMBIENTALI";
            // 
            // btn_datiAuto
            // 
            this.btn_datiAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datiAuto.Location = new System.Drawing.Point(10, 91);
            this.btn_datiAuto.Name = "btn_datiAuto";
            this.btn_datiAuto.Size = new System.Drawing.Size(345, 44);
            this.btn_datiAuto.TabIndex = 4;
            this.btn_datiAuto.Text = "RACCOGLI DATI AUTO";
            this.btn_datiAuto.UseVisualStyleBackColor = true;
            this.btn_datiAuto.Click += new System.EventHandler(this.btn_datiAuto_Click);
            // 
            // tmr_raccoltaDatiAuto
            // 
            this.tmr_raccoltaDatiAuto.Tick += new System.EventHandler(this.tmr_raccoltaDatiAuto_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1213, 674);
            this.Controls.Add(this.pnl_dati);
            this.Controls.Add(this.pnl_luogo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ANALISI DATI AMBIENTALI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_luogo.ResumeLayout(false);
            this.pnl_luogo.PerformLayout();
            this.pnl_dati.ResumeLayout(false);
            this.tbc_dati.ResumeLayout(false);
            this.tbp_home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbp_grafici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chr_grafico)).EndInit();
            this.tbp_analisi.ResumeLayout(false);
            this.tbp_analisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_grafico;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_titoloLuogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_orario;
        private System.Windows.Forms.Label lbl_dataOdierna;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_datiAuto;
        private System.Windows.Forms.Timer tmr_raccoltaDatiAuto;
    }
}

