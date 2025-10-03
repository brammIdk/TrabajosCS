using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03102501
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1: Imprimir la suma de los 100 números impares consecutivos menores a 500
utilizando la estructura "Hacer Mientras".
Objetivo:
Este ejercicio debe realizarse con la estructura repetitiva do-while, que asegura que la
acción se ejecute al menos una vez antes de verificar la condición.*/
            int res = 1;
            int maxlen = 500;
            int toSum = 10;
            int i = 1;
            if (toSum < maxlen) 
            { 
                do
                {//salio mal
                    i += 2;
                    res += i;
                }
                while (i <= maxlen+2);
            }
            Console.WriteLine(res);

            /*if (toSum < maxlen)
            { 
                for (int i = 1; i <= toSum+2; i += 2)
                {
                    res += i;
                }
            }*/
        }
    }
}
