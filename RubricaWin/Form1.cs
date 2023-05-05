using Microsoft.CSharp.RuntimeBinder;
using System.Text.Json;

namespace RubricaWin
{
    public partial class Form1 : Form
    {
        private List<Contatto> rubrica = new List<Contatto>();
        public Form1()
        {
            InitializeComponent();
            Caricamento();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            int id = (rubrica.Count > 0) ? rubrica.Max(x => x.ID) + 1 : 1;
            rubrica.Add(new(id, txtNome.Text, txtCognome.Text, txtTelefono.Text));
            txtNome.Text = "";
            txtCognome.Text = "";
            txtTelefono.Text = "";
            lstContatti.Items.Add(rubrica[rubrica.Count - 1].ToString());
        }

        private void messaggio(string messaggio)
        {
            lstContatti.Items.Clear();
            lstContatti.Items.Add(messaggio);
        }

        private void btnVisTutto_Click(object sender, EventArgs e)
        {
            if (rubrica.Count > 0)
            {
                lstContatti.Items.Clear();
                foreach (Contatto c in rubrica)
                {
                    lstContatti.Items.Add(c.ToString());
                }
            }
        }

        private void Caricamento()
        {
            try
            {
                string? buffer = File.ReadAllText("rubrica.json");
                rubrica = JsonSerializer.Deserialize<List<Contatto>>(buffer);
                lstContatti.Items.AddRange(rubrica.ToArray());
                cmbID.DataSource = rubrica;
                cmbID.DisplayMember = "nome";
                cmbID.ValueMember = "ID";
            }
            catch
            {
                rubrica = new List<Contatto>();
                messaggio("Impossibile caricare la lista"); 
                throw;
            }
        }
    }
}