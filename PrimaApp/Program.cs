using PrimaApp;
using System.Numerics;
using System.Text; 
using System.IO;
using System.Reflection.Metadata.Ecma335;

internal class Program
{

    static void scriviTabellina(int baseTabellina, int numeroVolte)
    {
        string nomeFile = $"tabellina_{baseTabellina}.txt";
        File.WriteAllText(nomeFile, $"TABELLINA DEL {baseTabellina}\n");
        for (int i = 0; i < numeroVolte; i++)
        {
            int risultato = baseTabellina * i;
            string testo = $"{baseTabellina}\t*\t{i}\t=\t{risultato}\n";

            File.AppendAllText(nomeFile, testo, Encoding.UTF8);
        }
    }
    //Primo parametro è la base della tabellina
    //Il secondo parametro è la quantità di volte da ciclare
    private static void Main(string[] args) 
    {
        bool richiestaTabellina = true;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        int baseTabellina, numeroVolte;
        if (args.Length == 2)
        {
            baseTabellina = int.Parse(args[0]);
            numeroVolte = int.Parse(args[1]) + 1;
            scriviTabellina(baseTabellina, numeroVolte);
        }
        else
        {
            while (richiestaTabellina)
            {
                string richiesta = Utility.chiedi("Che tabellina vuoi?");
                baseTabellina = int.Parse(richiesta);
                numeroVolte = Utility.chiediNumero("Quante vuole lo vuoi cliclare? ") + 1;
                scriviTabellina(baseTabellina, numeroVolte);

                string risposta = Utility.chiedi("Vuoi un'altra tabellina (S/N)? ");
                richiestaTabellina = risposta == "s";
               
                Console.ReadLine();
            }
            Console.WriteLine("Buona giornata! (Premi un tasto per uscire)");
        }
       
    }   
}