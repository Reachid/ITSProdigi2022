namespace RubricaWin
{
    partial class Form1
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
            txtNome = new TextBox();
            txtTelefono = new TextBox();
            txtCognome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnInserisci = new Button();
            lstContatti = new ListBox();
            btnSalva = new Button();
            btnVisTutto = new Button();
            cmbID = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(124, 6);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(124, 64);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(314, 23);
            txtTelefono.TabIndex = 1;
            // 
            // txtCognome
            // 
            txtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCognome.Location = new Point(124, 35);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(314, 23);
            txtCognome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // btnInserisci
            // 
            btnInserisci.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInserisci.Location = new Point(12, 133);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(60, 23);
            btnInserisci.TabIndex = 6;
            btnInserisci.Text = "Inserisci";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // lstContatti
            // 
            lstContatti.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstContatti.FormattingEnabled = true;
            lstContatti.ItemHeight = 15;
            lstContatti.Location = new Point(12, 174);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(426, 184);
            lstContatti.TabIndex = 7;
            // 
            // cmbID
            // 
            cmbID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(124, 93);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(121, 23);
            cmbID.TabIndex = 11;
 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 380);
            Controls.Add(label4);
            Controls.Add(cmbID);
            Controls.Add(lstContatti);
            Controls.Add(btnInserisci);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCognome);
            Controls.Add(txtTelefono);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Rubrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefono;
        private TextBox txtCognome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInserisci;
        private ListBox lstContatti;
        private Button btnSalva;
        private Button btnVisTutto;
        private ComboBox cmbID;
        private Label label4;
    }
}