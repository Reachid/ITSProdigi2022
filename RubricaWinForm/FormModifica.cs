using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace RubricaWinForm
{
    public partial class FormModifica : Form
    {
        public Contatto risultato;
        public int id;
        public FormModifica(Contatto c)
        {
            if(c != null)
            {
                InitializeComponent();
                id = c.idContatto;
                txtModificaNome.Text = c.nome;
                txtModificaCognome.Text = c.cognome;
                txtModificaTelefono.Text = c.telefono;
            }
            else
            {
                MessageBox.Show("Impossibile aprire il form di modifica!"); 
            }
           
        }

        private void FormModifica_Load(object sender, EventArgs e)
        {

        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            risultato = new Contatto(id, txtModificaNome.Text, txtModificaCognome.Text, txtModificaTelefono.Text);
            this.Close();
        }
    }
}
