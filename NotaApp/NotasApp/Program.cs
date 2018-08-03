using System;
using System.Collections.Generic;

namespace NotasApp
{
    class Program
    {
        //Integrantes:
        //Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido la aplicacion de notas");

            bool continuar = true;
            List<int> notas = new List<int>();

            while (continuar) {
                Console.WriteLine("Íngrese su nota: ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int number))
                {
                    notas.Add(number);
                    Console.WriteLine("¿Termino(escriba N para terminar cualquier otra tecla y enter para continuar)? ");
                    string stringContinuar = Console.ReadLine();

                    if (stringContinuar.ToUpper() == "N")
                        continuar = false;
                    else
                        continuar = true;
                }
                else
                {
                    Console.WriteLine("Valor ingresado no es numero. Hasta luego!");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            int promedio = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                promedio += notas[i];
            }

            promedio = promedio / notas.Count;

            Console.WriteLine("Su promedio es: " + promedio);

            Console.WriteLine("Hecho por Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

        }
    }
}
