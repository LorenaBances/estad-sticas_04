using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estadísticas_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxPersonas = 50;
            int contador = 0;
            int totalIngresos = 678;
            int totalSalidas = 656;
            int vecesLleno = 6;
            int vecesVacio = 4;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("El programa ha terminado");
                Console.WriteLine("=================================");

                Console.WriteLine("Estadísticas:");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(totalIngresos + " personas ingresaron");
                Console.WriteLine(totalSalidas + " personas salieron");
                Console.WriteLine(vecesLleno + " veces se llenó el local");
                Console.WriteLine("Estuvo vacío " + vecesVacio + " veces");

                Console.WriteLine("Presione [ x ] para salir.");
                Console.Write("_");

                string opcion = Console.ReadLine().ToLower();

                if (opcion == "x")
                {
                    Console.WriteLine("Terminando el programa...");
                    return;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, presione [ x ] para salir.");
                    Console.ReadKey();
                }
            }
        }
    }
}
