using System.Security.Cryptography.X509Certificates;
using System.IO; 

namespace SecondaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            trovaFile(".sql"); 
        }

        public static void trovaFile(string estensione, string path = "C:/")
        {

            IEnumerable<String> files;
            IEnumerable<String> sottoDirectory;

            try
            {
                files = Directory.EnumerateFiles(path);
                
            }
            catch (Exception)
            {
                files = new List<String>();
                Console.WriteLine($"{path} : Accesso negato!"); 


            }

            try
            {
                sottoDirectory = Directory.EnumerateDirectories(path);
            }
            catch(Exception)
            {
                sottoDirectory = new List<String>();
            }


            foreach (String file in files)
            {
                if (file.EndsWith(estensione))
                {
                    Console.WriteLine(file);
                }
            }
                
                    

            foreach (String sottoCartella in sottoDirectory)
            {
                trovaFile(estensione, sottoCartella);
            }

        }
    }
}