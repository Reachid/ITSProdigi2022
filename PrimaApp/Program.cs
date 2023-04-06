using PrimaApp;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        bool richiestaTabellina = true; 
        while(richiestaTabellina)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            string richiesta = Utility.chiedi("Che tabellina vuoi?");

            int baseTabellina = int.Parse(richiesta), numeroVolte = Utility.chiediNumero("Quante vuole lo vuoi cliclare? "); ;
            for (int i = 0; i < numeroVolte + 1; i++)
            {
                int risultato = baseTabellina * i;
                Console.Write($"{baseTabellina}\t*\t{i}\t=\t{risultato}\n");
            }

            string risposta = Utility.chiedi("Vuoi un'altra tabellina (S/N)? ");
            richiestaTabellina = risposta == "s"; 
        }
        Console.WriteLine("Buona giornata! (Premi un tasto per uscire)");
        Console.ReadLine();
    }   
}