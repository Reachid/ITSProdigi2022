namespace LabirintoWinForm
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
            this.btnRisolvi = new System.Windows.Forms.Button();
            this.pcbLabirinto = new System.Windows.Forms.PictureBox();
            this.lstSoluzioni = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuApri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.digApri = new System.Windows.Forms.OpenFileDialog();
            this.digSalva = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLabirinto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRisolvi
            // 
            this.btnRisolvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRisolvi.Location = new System.Drawing.Point(12, 449);
            this.btnRisolvi.Name = "btnRisolvi";
            this.btnRisolvi.Size = new System.Drawing.Size(766, 23);
            this.btnRisolvi.TabIndex = 0;
            this.btnRisolvi.Text = "Risolvi";
            this.btnRisolvi.UseVisualStyleBackColor = true;
            this.btnRisolvi.Click += new System.EventHandler(this.btnRisolvi_Click);
            // 
            // pcbLabirinto
            // 
            this.pcbLabirinto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbLabirinto.Location = new System.Drawing.Point(12, 27);
            this.pcbLabirinto.Name = "pcbLabirinto";
            this.pcbLabirinto.Size = new System.Drawing.Size(391, 416);
            this.pcbLabirinto.TabIndex = 1;
            this.pcbLabirinto.TabStop = false;
            this.pcbLabirinto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbLabirinto_MouseMove);
            // 
            // lstSoluzioni
            // 
            this.lstSoluzioni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSoluzioni.FormattingEnabled = true;
            this.lstSoluzioni.IntegralHeight = false;
            this.lstSoluzioni.Location = new System.Drawing.Point(420, 27);
            this.lstSoluzioni.Name = "lstSoluzioni";
            this.lstSoluzioni.Size = new System.Drawing.Size(349, 416);
            this.lstSoluzioni.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApri,
            this.menuSalva,
            this.menuEsci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuApri
            // 
            this.menuApri.Name = "menuApri";
            this.menuApri.Size = new System.Drawing.Size(41, 20);
            this.menuApri.Text = "Apri";
            this.menuApri.Click += new System.EventHandler(this.aPriToolStripMenuItem_Click);
            // 
            // menuSalva
            // 
            this.menuSalva.Name = "menuSalva";
            this.menuSalva.Size = new System.Drawing.Size(46, 20);
            this.menuSalva.Text = "Salva";
            this.menuSalva.Click += new System.EventHandler(this.menuSalva_Click);
            // 
            // menuEsci
            // 
            this.menuEsci.Name = "menuEsci";
            this.menuEsci.Size = new System.Drawing.Size(39, 20);
            this.menuEsci.Text = "Esci";
            this.menuEsci.Click += new System.EventHandler(this.menuEsci_Click);
            // 
            // digApri
            // 
            this.digApri.FileName = "openFileDialog1";
            this.digApri.Filter = "Tutti i file|*.*|File immagine|*.jpg";
            // 
            // digSalva
            // 
            this.digSalva.Filter = "Tutti i file|*.*|File immagine|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 484);
            this.Controls.Add(this.lstSoluzioni);
            this.Controls.Add(this.pcbLabirinto);
            this.Controls.Add(this.btnRisolvi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLabirinto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRisolvi;
        private System.Windows.Forms.PictureBox pcbLabirinto;
        private System.Windows.Forms.ListBox lstSoluzioni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuApri;
        private System.Windows.Forms.ToolStripMenuItem menuSalva;
        private System.Windows.Forms.ToolStripMenuItem menuEsci;
        private System.Windows.Forms.OpenFileDialog digApri;
        private System.Windows.Forms.SaveFileDialog digSalva;
    }
}

