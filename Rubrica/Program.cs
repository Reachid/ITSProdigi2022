using System.Diagnostics;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json; 

namespace Rubrica
{
    internal class Program
    {
        static private List<Contatto> contatti; 
        static void Main(string[] args)
        {
           

            contatti = new List<Contatto>();
            string comando = "";
            do
            {
                comando = chiedi("Cosa vuoi fare?"); 
                switch(comando)
                {
                    case "crea":
                    case "nuovo": //Create
                        int nuovoID; 
                        if(contatti.Count > 0)
                        {
                            nuovoID = contatti.Max(x => x.idContatto) + 1; 
                        }
                        else
                        {
                            nuovoID = 1;
                        }
                        contatti.Add(new( nuovoID, chiedi("Nome", false), chiedi("Cognome", false), chiedi("Telefono", false) ));
                        Console.WriteLine($"Cobtatti presenti: {Contatto.quanti}"); 
                        break;
                    case "vedi": //Read
                        string chi = chiedi("Inserisci il nome", false); 
                        List<Contatto> selezionati =  contatti.Where(singolo => singolo.nome.Contains(chi)).ToList();
                        foreach(Contatto singolo in selezionati)
                        {
                            Console.WriteLine(singolo.ToString()); 
                        }
                        break;
                    case "elimina": 
                    case "cancella": //Delete
                        int daCancellare = int.Parse(chiedi("ID da cancellare", false));
                        int cancellati = contatti.RemoveAll(x => x.idContatto == daCancellare); 
                        Console.WriteLine($"Cancellati {cancellati} contatti!");
                        break;

                    case "modifica": //Update
                        int daModificare = int.Parse(chiedi("ID da modificare", false));
                        Contatto? modifica = contatti.FirstOrDefault(x => x.idContatto == daModificare); 
                        if(modifica != null)
                        {
                            modifica.nome = chiedi($"Nome (attuale: {modifica.nome})");
                            modifica.cognome = chiedi($"Cognome (attuale: {modifica.cognome})");
                            modifica.telefono = chiedi($"Telefono (attuale {modifica.telefono})"); 
                        }
                        break;
                    
                    case "salva":
                        File.WriteAllText("rubrica.json", JsonSerializer.Serialize(contatti));
                        Console.WriteLine("Rubrica salvata sul disco!"); 
                        break;

                    case "apri":
                        try
                        {
                            string buffer = File.ReadAllText("rubrica.json");
                            contatti = JsonSerializer.Deserialize<List<Contatto>>(buffer);
                            Console.WriteLine($"Caricati {contatti.Count} contatti!"); 
                        }
                        catch (Exception ex)
                        {
                            contatti = new();
                            Console.WriteLine("Errore, ricaricamento del file...");
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                    case "vedi tutti":
                        foreach (Contatto contatto in contatti)
                        {
                            Console.WriteLine(contatto.ToString()); 
                        }
                        break;
                    case "pulisci":
                        Console.Clear(); 
                        break; 
                    default:
                        Console.WriteLine("Non ho capito..."); 
                        break;
                }


            } while (comando != "esci"); 

        }

        static private string chiedi(string domanda, bool corretto = true)
        {
            Console.Write(domanda + ": ");
            if (corretto)
            {
                return Console.ReadLine().ToLower().Trim();
            }
            else
            {
                return Console.ReadLine().Trim(); 
            }
        }
    }
}