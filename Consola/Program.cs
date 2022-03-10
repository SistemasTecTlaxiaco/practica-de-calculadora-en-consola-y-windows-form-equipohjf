using System;
using LibreriaCalculadora;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Class1.raizCuadrada(num));
        }
    }
}
