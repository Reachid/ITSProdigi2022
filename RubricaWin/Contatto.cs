using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaWin
{
    internal class Contatto
    {
        public int ID { get; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string telefono { get; set; }
        public DateTime dataCreazione { get; set; } = DateTime.Now;

        public Contatto(int iD, string nome, string cognome, string telefono)
        {
            this.ID = iD;
            this.nome = nome;
            this.cognome = cognome;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return $"{this.ID}\t{this.nome}\t{this.cognome}\t\t{this.telefono}\t{this.dataCreazione}"; 
        }
    }
}
