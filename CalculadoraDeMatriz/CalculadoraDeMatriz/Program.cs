using System;

namespace CalculadoraDeMatriz
{
    class Program
    {
        //Integrantes:
        //Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de matrices");
            Console.WriteLine("Ingrese el size de las matrices: ");
            String sizeInPut = Console.ReadLine();
            int[,] a;
            int[,] b;
            int[,] resultado = new int[1,1];

            if (Int32.TryParse(sizeInPut, out int tamano))
            {
                a = new int[tamano, tamano];
                b = new int[tamano, tamano];

                for (int f = 0; f < tamano; f++)
                {
                    for (int c = 0; c < tamano; c++)
                    {
                        Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]  de la matriz a: ");
                        string linea = Console.ReadLine();
                        if (Int32.TryParse(linea, out int valor))
                        {
                            a[f, c] = valor;
                        }
                        else
                        {
                            Console.WriteLine("Error - Valor ingresado no es numero. Hasta luego!");
                            Console.WriteLine("Press any key to continue . . .");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                    }
                }

                for (int f = 0; f < tamano; f++)
                {
                    for (int c = 0; c < tamano; c++)
                    {
                        Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "] de la matriz b: ");
                        string linea = Console.ReadLine();
                        if (Int32.TryParse(linea, out int valor))
                        {
                            b[f, c] = valor;
                        }
                        else
                        {
                            Console.WriteLine("Error - Valor ingresado no es numero. Hasta luego!");
                            Console.WriteLine("Press any key to continue . . .");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                    }
                }
                Console.WriteLine("¿Que desea hacer sumar[S] o restar[R]?");

                string accion = Console.ReadLine();


                if (accion.ToUpper() == "S" || accion.ToUpper() == "R") {
                    resultado = new int[tamano, tamano];
                    if (accion.ToUpper() == "S")
                    {
                        for (int f = 0; f < tamano; f++)
                        {
                            for (int c = 0; c < tamano; c++)
                            {
                                resultado[f, c] = a[f, c] + b[f, c];
                            }
                        }
                    }
                    else
                    {
                        for (int f = 0; f < tamano; f++)
                        {
                            for (int c = 0; c < tamano; c++)
                            {
                                resultado[f, c] = a[f, c] -  b[f, c];
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Error - Accion no soportada. Hasta luego!");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


            }
            else
            {
                Console.WriteLine("Error - Valor ingresado no es numero. Hasta luego!");
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("El Resultado es");

            for (int f = 0; f < tamano; f++)
            {
                for (int c = 0; c < tamano; c++)
                {
                    Console.Write(" "+resultado[f,c] +" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Hecho por Manuel Jesus Taveras Rivera -  Matricula : 17-siin-1-114");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
}
