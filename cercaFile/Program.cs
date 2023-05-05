using System.IO;

namespace cercaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;
            string estensione; 

            if(args.Length != 1) { 
                Console.Write("Inserisci il path (Default: C:/): ");
                path = Console.ReadLine();
                Console.Write("Inserisci l'estensione (Senza il punto): ");
                estensione = "." + Console.ReadLine();
                if(path == "")
                {
                    path = $"C:/"; 
                }
            }
            else
            {
                estensione = "." + args[0]; 
                if(args.Length == 1)
                {
                    path = $"C:/"; 
                }
                else
                {
                    path = args[1];
                }                
            }          
            cercaFileDirectory(estensione, path);

           

        }

        static void cercaFileDirectory(string estensione, string path)
        {
            List<string> files;
            List<string> directories; 
            
            try
            {
                files = Directory.EnumerateFiles(path).ToList<string>(); 
            }
            catch (Exception)
            {
                files = new List<string>();
                Console.WriteLine($"{path} : Accesso negato!");

            }

            try
            {
                directories = Directory.EnumerateDirectories(path).ToList<string>();
            }
            catch (Exception)
            {
               directories = new List<string>();
            }

            foreach (string file in files)
            {
                if (file.EndsWith(estensione))
                {
                    Console.WriteLine(file); 
                }
            }

            foreach(string directory in directories)
            {
                cercaFileDirectory(estensione, directory); 
            }
        }
    }
}