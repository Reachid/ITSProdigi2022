using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuartaApp
{
    [Table("persone")]
    internal class Persona
    {
        [Key]
        public int idPersona { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string cognome { get; set; }
        [Required]
        public int età { get; set; }
        public string indirizzo { get; set; }
        public string? targa { get; set; }
        public int? cellulare { get; set; }
        public DateTime dataCreazione { get; } = DateTime.Now;

        public Persona(string nome, string cognome, int età)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = età;
            idPersona += 1; 
        }
    }
}
