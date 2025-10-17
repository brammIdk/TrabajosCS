using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc;

namespace _17102502
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, opc, res;
            bool exit = false;

            while (!exit)
            { 
                MostrarTitulo();
                Console.WriteLine("ingrese un primer valor: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un segundo valor: ");
                b = double.Parse(Console.ReadLine());
                MostrarOp();
                opc = double.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Class1.OutSuma(a, b, res);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }


            }
        }
        static void MostrarTitulo()
        {
            Console.WriteLine("   _____      _            _           _                 ");
            Console.WriteLine("  / ____|    | |          | |         | |                ");
            Console.WriteLine(" | |     __ _| | ___ _   _| | __ _  __| | ___  _ __ __ _ ");
            Console.WriteLine(" | |    / _` | |/ __| | | | |/ _` |/ _` |/ _ \\| '__/ _` |");
            Console.WriteLine(" | |___| (_| | | (__| |_| | | (_| | (_| | (_) | | | (_| |");
            Console.WriteLine("  \\_____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__,_|\\___/|_|  \\__,_|");
        }
        static void MostrarOp()
        {
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
        }
        

    }
}
