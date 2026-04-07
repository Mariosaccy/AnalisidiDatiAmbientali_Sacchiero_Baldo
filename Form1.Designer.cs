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
            this.btn_luogo = new System.Windows.Forms.Button();
            this.txt_luogo = new System.Windows.Forms.TextBox();
            this.pnl_luogo = new System.Windows.Forms.Panel();
            this.pnl_dati = new System.Windows.Forms.Panel();
            this.btn_dati = new System.Windows.Forms.Button();
            this.tbc_dati = new System.Windows.Forms.TabControl();
            this.tbp_home = new System.Windows.Forms.TabPage();
            this.tbp_grafici = new System.Windows.Forms.TabPage();
            this.btn_mem = new System.Windows.Forms.Button();
            this.pnl_luogo.SuspendLayout();
            this.pnl_dati.SuspendLayout();
            this.tbc_dati.SuspendLayout();
            this.tbp_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_luogo
            // 
            this.btn_luogo.Location = new System.Drawing.Point(331, 55);
            this.btn_luogo.Name = "btn_luogo";
            this.btn_luogo.Size = new System.Drawing.Size(75, 23);
            this.btn_luogo.TabIndex = 1;
            this.btn_luogo.Text = "inizia";
            this.btn_luogo.UseVisualStyleBackColor = true;
            this.btn_luogo.Click += new System.EventHandler(this.btn_luogo_Click);
            // 
            // txt_luogo
            // 
            this.txt_luogo.Location = new System.Drawing.Point(318, 16);
            this.txt_luogo.Name = "txt_luogo";
            this.txt_luogo.Size = new System.Drawing.Size(100, 20);
            this.txt_luogo.TabIndex = 3;
            // 
            // pnl_luogo
            // 
            this.pnl_luogo.Controls.Add(this.txt_luogo);
            this.pnl_luogo.Controls.Add(this.btn_luogo);
            this.pnl_luogo.Location = new System.Drawing.Point(32, 184);
            this.pnl_luogo.Name = "pnl_luogo";
            this.pnl_luogo.Size = new System.Drawing.Size(736, 104);
            this.pnl_luogo.TabIndex = 4;
            // 
            // pnl_dati
            // 
            this.pnl_dati.Controls.Add(this.tbc_dati);
            this.pnl_dati.Location = new System.Drawing.Point(54, 12);
            this.pnl_dati.Name = "pnl_dati";
            this.pnl_dati.Size = new System.Drawing.Size(693, 410);
            this.pnl_dati.TabIndex = 5;
            // 
            // btn_dati
            // 
            this.btn_dati.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dati.Location = new System.Drawing.Point(279, 125);
            this.btn_dati.Name = "btn_dati";
            this.btn_dati.Size = new System.Drawing.Size(120, 44);
            this.btn_dati.TabIndex = 2;
            this.btn_dati.Text = "raccogli";
            this.btn_dati.UseVisualStyleBackColor = true;
            this.btn_dati.Click += new System.EventHandler(this.btn_dati_Click);
            // 
            // tbc_dati
            // 
            this.tbc_dati.Controls.Add(this.tbp_home);
            this.tbc_dati.Controls.Add(this.tbp_grafici);
            this.tbc_dati.Location = new System.Drawing.Point(3, 3);
            this.tbc_dati.Name = "tbc_dati";
            this.tbc_dati.SelectedIndex = 0;
            this.tbc_dati.Size = new System.Drawing.Size(687, 404);
            this.tbc_dati.TabIndex = 3;
            // 
            // tbp_home
            // 
            this.tbp_home.Controls.Add(this.btn_mem);
            this.tbp_home.Controls.Add(this.btn_dati);
            this.tbp_home.Location = new System.Drawing.Point(4, 22);
            this.tbp_home.Name = "tbp_home";
            this.tbp_home.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_home.Size = new System.Drawing.Size(679, 378);
            this.tbp_home.TabIndex = 0;
            this.tbp_home.Text = "Home";
            this.tbp_home.UseVisualStyleBackColor = true;
            // 
            // tbp_grafici
            // 
            this.tbp_grafici.Location = new System.Drawing.Point(4, 22);
            this.tbp_grafici.Name = "tbp_grafici";
            this.tbp_grafici.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_grafici.Size = new System.Drawing.Size(679, 378);
            this.tbp_grafici.TabIndex = 1;
            this.tbp_grafici.Text = "Grafici";
            this.tbp_grafici.UseVisualStyleBackColor = true;
            // 
            // btn_mem
            // 
            this.btn_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mem.Location = new System.Drawing.Point(279, 209);
            this.btn_mem.Name = "btn_mem";
            this.btn_mem.Size = new System.Drawing.Size(120, 44);
            this.btn_mem.TabIndex = 3;
            this.btn_mem.Text = "salva";
            this.btn_mem.UseVisualStyleBackColor = true;
            this.btn_mem.Click += new System.EventHandler(this.btn_mem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

