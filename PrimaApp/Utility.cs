using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaApp
{
    internal class Utility
    {
        /// <summary>
        /// funzione per poter porre una domanda all'utente tramite console
        /// </summary>
        /// <param name="domanda">La domanda da porre all'utente.</param>
        /// <returns>Quello che l'utente che ha scritto in console</returns>
        public static string chiedi(string domanda)
        {
            Console.Write(domanda + ": ");
            string? risposta = Console.ReadLine();
            return risposta;
        }

        /// <summary>
        /// Prende in input una domanda che viene posta all'utente
        /// </summary>
        /// <param name="domanda"></param>
        /// <returns>Ritorna quante volte dev'essere eseguita un'operazione</returns>
        public static int chiediNumero(string domanda)
        {
            Console.Write(domanda + ": ");
            int risposta = int.Parse(Console.ReadLine());
            return risposta;
        }
    }
}
