namespace Blocco_note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuEsci_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Sei sicuro?", "Uscita dal programma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void mnuApri_Click(object sender, EventArgs e)
        {
            DialogResult risultato = dlgApri.ShowDialog();
            if (risultato == DialogResult.OK)
            {
                txtCorpo.Text = File.ReadAllText(dlgApri.FileName);

            }
        }

        private void mnuSalva_Click(object sender, EventArgs e)
        {
            DialogResult risultato = dlgSalva.ShowDialog();
            if (risultato == DialogResult.OK)
            {
                File.WriteAllText(dlgSalva.FileName, txtCorpo.Text);
            }
        }

        private void txtCorpo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}