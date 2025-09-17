using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1.opcion '1'");
            Console.WriteLine("2.opcion '2'");
            Console.WriteLine("3.opcion '3'");
            Console.WriteLine("4.salir '4'\n");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("selecciono la opcion 1");
                    break;
                case 2:
                    Console.WriteLine("selecciono la opcion 2");
                    break;
                case 3:
                    Console.WriteLine("selecciono la opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("ingrese un valor correcto:");
                    break;         
            }

        }
    }
}
