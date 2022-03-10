using System;
using LibreriaCalculadora;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            double Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero");
            double Exponente = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Class1.potencia(Base, Exponente));
        }
    }
}
