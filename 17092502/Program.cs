using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17092502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio02");
            Console.WriteLine("Monto Pension: ");
            double montoPension = double.Parse(Console.ReadLine());
            Console.WriteLine("Promedio: ");
            double promedio = double.Parse(Console.ReadLine());

            if (promedio >= 0 && promedio <= 20)
            {
                double descuento = 0.0;
                if (promedio >= 19)
                {
                    descuento = 0.20;
                }
                else if (promedio >= 18)
                {
                    descuento = 0.10;
                }
                else if (promedio >= 17)
                {
                    descuento = 0.05;
                }

                double montoDsto = montoPension * descuento;
                double nuevoMonto = montoPension - montoDsto;

                Console.WriteLine($"Monto descuento: {montoDsto:F2}");
                Console.WriteLine($"Monto Pension: {nuevoMonto:F2}");
            }
            else
            {
                Console.WriteLine("ingrese una nota valida.");
            }
                Console.ReadKey();   
        }
    }
}
