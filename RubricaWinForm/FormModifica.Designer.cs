namespace RubricaWinForm
{
    partial class FormModifica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtModificaNome = new TextBox();
            txtModificaCognome = new TextBox();
            txtModificaTelefono = new TextBox();
            btnConferma = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // txtModificaNome
            // 
            txtModificaNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModificaNome.Location = new Point(148, 16);
            txtModificaNome.Name = "txtModificaNome";
            txtModificaNome.Size = new Size(100, 23);
            txtModificaNome.TabIndex = 3;
            // 
            // txtModificaCognome
            // 
            txtModificaCognome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModificaCognome.Location = new Point(148, 45);
            txtModificaCognome.Name = "txtModificaCognome";
            txtModificaCognome.Size = new Size(100, 23);
            txtModificaCognome.TabIndex = 4;
            // 
            // txtModificaTelefono
            // 
            txtModificaTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModificaTelefono.Location = new Point(148, 74);
            txtModificaTelefono.Name = "txtModificaTelefono";
            txtModificaTelefono.Size = new Size(100, 23);
            txtModificaTelefono.TabIndex = 5;
            // 
            // btnConferma
            // 
            btnConferma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConferma.DialogResult = DialogResult.OK;
            btnConferma.Location = new Point(12, 103);
            btnConferma.Name = "btnConferma";
            btnConferma.Size = new Size(236, 23);
            btnConferma.TabIndex = 6;
            btnConferma.Text = "Conferma Modifica";
            btnConferma.UseVisualStyleBackColor = true;
            btnConferma.Click += btnConferma_Click;
            // 
            // FormModifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 133);
            Controls.Add(btnConferma);
            Controls.Add(txtModificaTelefono);
            Controls.Add(txtModificaCognome);
            Controls.Add(txtModificaNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormModifica";
            Text = "FormModifica";
            Load += FormModifica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtModificaNome;
        private TextBox txtModificaCognome;
        private TextBox txtModificaTelefono;
        private Button btnConferma;
    }
}