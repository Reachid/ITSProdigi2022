using System.Reflection;

namespace QuartaApp
{
    internal class Program
    {
        static private List<Persona> persone = new List<Persona>();


        static void Main(string[] args)
        {
            //Esempio di riferimento
            int primaVariabile = 1;
            int secondaVariabile = 2; 
            somma(ref primaVariabile, secondaVariabile);
            Console.WriteLine(primaVariabile);

            //Somma delle età
            persone.Add(new("Giacomo", "Tizi", 30));
            persone.Add(new("Federico", "Rossi", 19));
            persone.Add(new("Luca", "Gialli", 56));
            persone.Add(new("Stefania", "Brizzi", 7));

            int totale = sommaEtà(persone[0], persone[1]);
            Console.WriteLine($"Totale delle età di è: {totale}");
            Console.WriteLine($"Perché {persone[0].nome} ha {persone[0].età} e {persone[1].nome} ha {persone[1].età}");

            Persona nuova = new Persona(persone[0].nome, persone[0].cognome, persone[0].età);
            nuova.età = 65;

            compila(nuova);
        }

        static int sommaEtà(Persona prima, Persona seconda)
        {
            prima.età += seconda.età;
            return prima.età; 
        }

        //Metodo per vedere il passaggio di una variabile per referenza
        static void somma(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine("Sto stampando a: {0}", a);
        }

        //clona(Persona persona); Serve per clonare un oggetto nonostante questi vengano passati per referenza
        static void compila(object o)
        {
            Type tipo = o.GetType();
            PropertyInfo[] props = tipo.GetProperties();
            foreach (PropertyInfo pi in props.Where(x => x.CanWrite))
            {
                Console.Write($"Dimmi {pi.Name}: ");
                var appoggio = Console.ReadLine();
                if (pi.PropertyType.Name == "Int32")
                {
                    pi.SetValue(o, int.Parse(appoggio));
                }
                else
                {
                    pi.SetValue(o, appoggio);
                }                
            }
        }

    }
}