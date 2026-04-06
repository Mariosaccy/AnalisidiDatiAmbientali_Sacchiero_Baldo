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
            this.pnl_luogo.SuspendLayout();
            this.pnl_dati.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_luogo
            // 
            this.btn_luogo.Location = new System.Drawing.Point(63, 55);
            this.btn_luogo.Name = "btn_luogo";
            this.btn_luogo.Size = new System.Drawing.Size(75, 23);
            this.btn_luogo.TabIndex = 1;
            this.btn_luogo.Text = "inizia";
            this.btn_luogo.UseVisualStyleBackColor = true;
            this.btn_luogo.Click += new System.EventHandler(this.btn_luogo_Click);
            // 
            // txt_luogo
            // 
            this.txt_luogo.Location = new System.Drawing.Point(50, 16);
            this.txt_luogo.Name = "txt_luogo";
            this.txt_luogo.Size = new System.Drawing.Size(100, 20);
            this.txt_luogo.TabIndex = 3;
            // 
            // pnl_luogo
            // 
            this.pnl_luogo.Controls.Add(this.txt_luogo);
            this.pnl_luogo.Controls.Add(this.btn_luogo);
            this.pnl_luogo.Location = new System.Drawing.Point(300, 175);
            this.pnl_luogo.Name = "pnl_luogo";
            this.pnl_luogo.Size = new System.Drawing.Size(200, 100);
            this.pnl_luogo.TabIndex = 4;
            // 
            // pnl_dati
            // 
            this.pnl_dati.Controls.Add(this.btn_dati);
            this.pnl_dati.Location = new System.Drawing.Point(300, 53);
            this.pnl_dati.Name = "pnl_dati";
            this.pnl_dati.Size = new System.Drawing.Size(200, 100);
            this.pnl_dati.TabIndex = 5;
            // 
            // btn_dati
            // 
            this.btn_dati.Location = new System.Drawing.Point(63, 39);
            this.btn_dati.Name = "btn_dati";
            this.btn_dati.Size = new System.Drawing.Size(75, 23);
            this.btn_dati.TabIndex = 2;
            this.btn_dati.Text = "raccogli";
            this.btn_dati.UseVisualStyleBackColor = true;
            this.btn_dati.Click += new System.EventHandler(this.btn_dati_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_luogo;
        private System.Windows.Forms.TextBox txt_luogo;
        private System.Windows.Forms.Panel pnl_luogo;
        private System.Windows.Forms.Panel pnl_dati;
        private System.Windows.Forms.Button btn_dati;
    }
}

