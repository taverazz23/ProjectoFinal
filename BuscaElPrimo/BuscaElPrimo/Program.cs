using System;
using System.Collections.Generic;

namespace BuscaElPrimo
{
    class Program
    {
        //Integrantes:
        //Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido busca el primo");
            Console.WriteLine("Obtenga los numeros primo de una lista");


            bool continuar = true;
            List<int> numeros = new List<int>();
            List<int> primos = new List<int>();

            while (continuar)
            {
                Console.WriteLine("Íngrese numero: ");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int number))
                {
                    numeros.Add(number);
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

            for (int i = 0; i < numeros.Count; i++)
            {
                if (IsPrime(numeros[i]))
                    {
                    primos.Add(numeros[i]);
                }
            }
            Console.WriteLine("Los numeros primos son:");

            for (int i = 0; i < primos.Count; i++)
            {
                Console.Write(primos[i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Hecho por Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }


}
