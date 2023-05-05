namespace RubricaWinForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            txtTelefono = new TextBox();
            lstVisualizza = new ListBox();
            btnInserisci = new Button();
            btnElimina = new Button();
            btnModifica = new Button();
            label4 = new Label();
            cmbNomi = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(121, 9);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 3;
            // 
            // txtCognome
            // 
            txtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCognome.Location = new Point(121, 38);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(237, 23);
            txtCognome.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(121, 67);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 23);
            txtTelefono.TabIndex = 5;
            // 
            // lstVisualizza
            // 
            lstVisualizza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstVisualizza.FormattingEnabled = true;
            lstVisualizza.ItemHeight = 15;
            lstVisualizza.Location = new Point(12, 191);
            lstVisualizza.Name = "lstVisualizza";
            lstVisualizza.Size = new Size(346, 109);
            lstVisualizza.TabIndex = 6;
            lstVisualizza.SelectedIndexChanged += lstVisualizza_SelectedIndexChanged;
            lstVisualizza.MouseDoubleClick += lstVisualizza_MouseDoubleClick;
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(12, 149);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(75, 23);
            btnInserisci.TabIndex = 7;
            btnInserisci.Text = "Inserisci";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(93, 149);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(75, 23);
            btnElimina.TabIndex = 8;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(174, 149);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 9;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Lista nomi";
            // 
            // cmbNomi
            // 
            cmbNomi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbNomi.FormattingEnabled = true;
            cmbNomi.Location = new Point(121, 96);
            cmbNomi.Name = "cmbNomi";
            cmbNomi.Size = new Size(121, 23);
            cmbNomi.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 314);
            Controls.Add(cmbNomi);
            Controls.Add(label4);
            Controls.Add(btnModifica);
            Controls.Add(btnElimina);
            Controls.Add(btnInserisci);
            Controls.Add(lstVisualizza);
            Controls.Add(txtTelefono);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtTelefono;
        private ListBox lstVisualizza;
        private Button btnInserisci;
        private Button btnElimina;
        private Button btnModifica;
        private Label label4;
        private ComboBox cmbNomi;
    }
}