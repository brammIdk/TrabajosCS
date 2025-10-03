using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03102503
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 3: Se necesita un algoritmo que calcule la talla más alta de todo el salón de clase.
Para ello, se debe preguntar al usuario si desea registrar o no a la siguiente persona, y solo
registrar las personas que deseen ser registradas.
Objetivo:
Aprender a trabajar con ciclos repetitivos y tomar decisiones en base a la entrada del
usuario (sí o no), para obtener la talla más alta de un grupo de personas*/

            /* preguntar si se registrara o no.
            en caso de si:
            asignar nombre con input;
                si tallaactual > tallamax
                    tallamax = tallaactual;
                    nombre = input 
           */
            string opt, nombre = "doe", input;
            int talla_actual, talla_max = 0;
            Console.WriteLine("Desea registrarse? Si/No");
            opt = Console.ReadLine().ToLower();
            while (true)
            { 
                if (opt == "si")
                {
                    Console.WriteLine("ingrese la talla: ");
                    talla_actual = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre: ");
                    input = Console.ReadLine();
                    if (talla_actual > talla_max)
                    {
                        talla_max = talla_actual;
                        nombre = input;
                    }
                }
                else if (opt == "no")
                {
                    Console.WriteLine("finalizando \n\n");
                    break;
                }

            }
            Console.WriteLine($"talla maxima: {talla_max} de parte de {nombre}");
        }
    }
}
