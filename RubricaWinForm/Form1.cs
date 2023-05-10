using System.Runtime.CompilerServices;
using System.Text.Json;

namespace RubricaWinForm
{
    public partial class Form1 : Form
    {
        public List<Contatto> rubrica = new List<Contatto>();

        public Form1()
        {
            InitializeComponent();
            caricamento();
        }

        private void caricamento()
        {
            if (!File.Exists("Rubrica.json")) File.Create("Rubrica.json");

            try
            {
                string buffer = File.ReadAllText("Rubrica.json");
                rubrica = JsonSerializer.Deserialize<List<Contatto>>(buffer);

                ricarica();
            }
            catch
            {
                rubrica = new List<Contatto>();
                messaggio("Impossibile caricare la lista!");
            }
        }

        private void messaggio(string messaggio)
        {
            lstVisualizza.Items.Clear();
            lstVisualizza.Items.Add(messaggio);
        }

        private void aggiungi()
        {
            int nuovoID = (rubrica.Count > 0) ? rubrica.Max(x => x.idContatto) + 1 : 1;
            rubrica.Add(new(nuovoID, txtNome.Text, txtCognome.Text, txtTelefono.Text));
            txtNome.Text = "";
            txtCognome.Text = "";
            txtTelefono.Text = "";
            salva();
            ricarica();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            aggiungi();
        }

        private void salva()
        {
            File.WriteAllText("Rubrica.json", JsonSerializer.Serialize(rubrica));
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            elimina((Contatto)cmbNomi.SelectedItem);
        }

        private void ricarica()
        {
            lstVisualizza.Items.Clear();
            lstVisualizza.Items.AddRange(rubrica.ToArray());
            cmbNomi.Items.Clear();
            cmbNomi.Text = "";
            cmbNomi.Items.AddRange(rubrica.ToArray());
            cmbNomi.DisplayMember = "nome";
            cmbNomi.ValueMember = "idContatto";
        }

        private void elimina(Contatto c)
        {
            rubrica.Remove(c);
            salva();
            ricarica();
        }

        private void lstVisualizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult rs = MessageBox.Show(this, "Sei sicuro di voler cancellare questo elemento?", "Conferma", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                elimina((Contatto)lstVisualizza.SelectedItem);
            }

        }

        private void lstVisualizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            FormModifica fm = new FormModifica((Contatto)lstVisualizza.SelectedItem);
            DialogResult rs = fm.ShowDialog();
            if(rs == DialogResult.OK)
            {
                foreach(Contatto c in rubrica)
                {
                    if(c.idContatto == fm.risultato.idContatto)
                    {
                        c.nome = fm.risultato.nome;
                        c.cognome = fm.risultato.cognome;
                        c.telefono = fm.risultato.telefono;
                    }
                }
                salva();
                ricarica(); 
            }

        }
    }
}