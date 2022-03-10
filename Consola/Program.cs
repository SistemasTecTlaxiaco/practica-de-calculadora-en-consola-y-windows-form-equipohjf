using System;
using LibreriaCalculadora;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

           
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Introducir un numero");
                    Console.WriteLine("2. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduzca un numero");
                            double num = double.Parse(Console.ReadLine());
                            Console.WriteLine("El resultado es: " + Class1.raizCuadrada(num));
                            break;

                        case 2:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 2");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
