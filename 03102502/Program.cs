using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03102502
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan números de forma continua hasta que se ingresa el número cero.
Calcular el promedio de los números mayores a 500 y el promedio de los números menores
a 500.
Objetivo:
Practicar el uso de estructuras repetitivas, el cálculo de promedios, y la división de los
números ingresados en dos grupos (mayores y menores a 500*/

            int res = 0;
            int majnum = 0, minnum = 0;
            int constr = 500;


            string input = Console.ReadLine();
            while (input != "0")
            {
                if (int.Parse(input) < constr)
                {
                    minnum += int.Parse(input);
                }
                else if (int.Parse(input) > constr)
                {
                    majnum += int.Parse(input);
                }
                else 
                {
                    res += int.Parse(input);
                }
                    input = Console.ReadLine();
            }
            Console.Clear();
            res += majnum + minnum;
            Console.WriteLine("suma menores numeros: "+minnum);
            Console.WriteLine("suma mayores numeros: "+majnum);
            Console.WriteLine("suma total: "+res);

        }
    }
}
