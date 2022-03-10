using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCalculadora
{
    public class Class1
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }
        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double mayor(double uno, double dos, double tres)
        {
            if (uno > dos && uno > tres)
            {
                return uno;
            }
            else
            {
                if (dos > uno && dos > tres)
                {
                    return dos;
                }
                else
                {
                    return tres;
                }
            }

        }

        public static double potencia(double Base, double exponente)
        {
            double resultado = Base;
            for (int i = 1; i < exponente; i++)
            {
                resultado *= Base;
            }
            return resultado;
        }

        public static double division(double divisor, double dividendo)
        {
            return divisor / dividendo;
        }

        public static double raizCuadrada(double numero)
        {
            double resultado = 0;
            for (double i = 1; true; i++)
            {
                if ((i * i) > numero)
                {
                    resultado = i - 1;
                    break;
                }
            }
            return resultado;
        }
    }
}
