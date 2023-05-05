using System.Data.SqlTypes;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace TerzaApp
{
    internal class Program
    {
        private static List<Casella> Scacchiera;
        private static Casella inizio, fine;
        private static List<string> soluzioni = new List<string>(); 

        static void Main(string[] args)
        {
            Scacchiera = new List<Casella>();

            string buffer = File.ReadAllText("labirinto.txt");
            string[] righe = buffer.Replace("\r", "").Split('\n');

            for (int y = 0; y < righe.Length; y++)
            {
                string riga = righe[y];
                for (int x = 0; x < riga.Length; x++)
                {
                    char cella = riga[x];
                    bool muro = cella == '1';
                    if (cella == 'S')
                    {
                        inizio = new(x, y, false);
                    }

                    if (cella == 'F')
                    {
                        fine = new(x, y, false);
                    }
                    Scacchiera.Add(new(x, y, muro));
                }
            }
            Analizza2(Scacchiera, inizio, fine);
            string? migliore = soluzioni.OrderBy(s => s.Length).FirstOrDefault();     
            if(migliore != null)
            {
                Console.WriteLine("Vince il " + migliore);
            }
        }

        private static void Analizza(List<Casella> scacchiera, Casella daAnalizzare, Casella arrivo, string percorso = "")
        {
            if (daAnalizzare.x == arrivo.x && daAnalizzare.y == arrivo.y)
            {
                soluzioni.Add(percorso); 
                Console.WriteLine($"Fatto: {percorso}");

            }
            else
            {
                //Analizza su
                Casella? su = scacchiera.Where(cella => cella.muro == false && cella.x == daAnalizzare.x && cella.y == daAnalizzare.y - 1).FirstOrDefault();
                if (su != null && !percorso.Contains($"[{su.x} {su.y}]"))
                {
                    Analizza(Scacchiera, su, arrivo, percorso + $"[{daAnalizzare.x} {daAnalizzare.y}]");
                }

                //Analizza dx
                Casella? dx = scacchiera.Where(cella => cella.muro == false && cella.x == daAnalizzare.x + 1 && cella.y == daAnalizzare.y).FirstOrDefault();
                if (dx != null && !percorso.Contains($"[{dx.x} {dx.y}]"))
                {
                    Analizza(Scacchiera, dx, arrivo, percorso + $"[{daAnalizzare.x} {daAnalizzare.y}]");
                }

                //Analizza giu
                Casella? giu = scacchiera.Where(cella => cella.muro == false && cella.x == daAnalizzare.x && cella.y == daAnalizzare.y + 1).FirstOrDefault();
                if (giu != null && !percorso.Contains($"[{giu.x} {giu.y}]"))
                {   
                    Analizza(Scacchiera, giu, arrivo, percorso + $"[{daAnalizzare.x} {daAnalizzare.y}]");   
                }

                //Analizza sx
                Casella? sx = scacchiera.Where(cella => cella.muro == false && cella.x == daAnalizzare.x - 1 && cella.y == daAnalizzare.y).FirstOrDefault();
                if (sx != null && !percorso.Contains($"[{sx.x} {sx.y}]"))
                {
                    Analizza(Scacchiera, sx, arrivo, percorso + $"[{daAnalizzare.x} {daAnalizzare.y}]");   
                }    
                
            }
        }

        private static void Analizza2(List<Casella> Scacchiera, Casella a, Casella da, string percorso = "")
        {
            //Comportamento selettivo

            if(a.x == da.x && a.y == da.y)
            {
                soluzioni.Add(percorso);
                Console.WriteLine(percorso); 
            }

           //Navigazione
           List<Casella> possibili =  Scacchiera.Where(
                cella =>
                !cella.muro && (
                    (cella.x == da.x && cella.y == da.y - 1) ||
                    (cella.x == da.x && cella.y == da.y + 1) ||
                    (cella.x == da.x - 1 && cella.y == da.y) ||
                    (cella.x == da.x + 1 && cella.y == da.y)
                )).ToList();
            
            foreach(Casella c  in possibili)
            {
                if(!percorso.Contains($"[{c.x} {c.y}]"))
                {
                    Analizza2(Scacchiera, c, a, $"{percorso} [{c.x} {c.y}]"); 
                }
            }
        }
    }
}