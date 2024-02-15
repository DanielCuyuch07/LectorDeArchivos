using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecturaDeArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leer texto completo
            string texto = System.IO.File.ReadAllText(@"C:\Users\danie\Desktop\TextoParaC.txt");
            Console.WriteLine("El archivo contiene el siguiente texto: {0}", texto);

            // Leer de a lienas
            string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\danie\Desktop\TextoParaC.txt");
            foreach (string line in lineas) { 
                Console.WriteLine("\t" + line);
            
            }


            Console.ReadLine();


        }
    }
}
