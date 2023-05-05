using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaWinForm
{
    public class Contatto
    {
        public int idContatto { get; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string telefono { get; set; }
        public DateTime dataCreazione { get; set; } = DateTime.Now;

        public Contatto(int idContatto, string nome, string cognome, string telefono)
        {
            this.idContatto = idContatto;
            this.nome = nome;
            this.cognome = cognome;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"{this.idContatto}\t{this.nome}\t{this.cognome}\t{this.telefono}\t{this.dataCreazione}"; 
        }
    }
}
