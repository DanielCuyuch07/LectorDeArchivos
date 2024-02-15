using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace lecturaDeArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String de lineas 
            // Metodo 1
            string[] lineas = { "Primera 200", "Segunda 242", "Tercera 240" };
            File.WriteAllLines(@"C:\Users\danie\Desktop\Texto.txt", lineas);


            // Construir un archivo a partir de lso ingresos que hace el usuario 
            // Metodo 2
            //Console.WriteLine("Ingrese el nombre del archivo");
            //string nombreArchivo = Console.ReadLine();
            //Console.WriteLine("Por favor ingrese el contenido del archivo");
            //string texto = Console.ReadLine();
            //File.WriteAllText (@"C:\Users\danie\Desktop\" +nombreArchivo + ".txt", texto);


            // Metodo 3 
            using (StreamWriter archivo = new StreamWriter(@"C:\Users\danie\Desktop\MiTexto2.txt"))
                // Solamente se escriban las lienas en nuestro determinando array 
                foreach (string line in lineas)
                {
                    if (line.Contains("Hello"))
                    {
                        archivo.WriteLine(line);
                    }
                }

            using (StreamWriter archivo = new StreamWriter(@"C:\Users\danie\Desktop\MiTexto2.txt", true))
            {
                archivo.WriteLine("Linea Adicional");
            }




                //// Leer texto completo
                //string texto = System.IO.File.ReadAllText(@"C:\Users\danie\Desktop\TextoParaC.txt");
                //Console.WriteLine("El archivo contiene el siguiente texto: {0}", texto);

                //// Leer de a lienas
                //string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\danie\Desktop\TextoParaC.txt");
                //foreach (string line in lineas) { 
                //    Console.WriteLine("\t" + line);

                //}


                Console.ReadLine();


        }
    }
}
