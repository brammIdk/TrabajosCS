using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17092504
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de cliente: ");
            Console.WriteLine("cliente general (G)");
            Console.WriteLine("cliente afiliado (A)");
            Console.WriteLine("Seleccione una opcion: ");
            char tipoCliente = inputKey();
            Console.Clear();
            Console.WriteLine("Forma de pago: ");
            Console.WriteLine("al contado (C)");
            Console.WriteLine("en plazos (P)");
            char tipoPago = inputKey();
            Console.Clear();

            Console.WriteLine("ingrese un monto para la recarga: ");
            double montoRecargo = double.Parse(Console.ReadLine());
            Console.Clear();

            double descuento = 1;

            if (tipoCliente == 'G')
            {
                if (tipoPago == 'C')
                {
                    descuento = 0.15;
                }
                else if (tipoPago == 'P')
                {
                    descuento = 0.10;
                }
                else
                {
                    Console.WriteLine("no ingreso una forma de pago correcta");
                }    
            }
            else if (tipoCliente == 'A')
            {
                if (tipoPago == 'C')
                {
                    descuento = 0.20;
                }
                else if (tipoPago == 'P')
                {
                    descuento = 0.05;
                }
                else
                {
                    Console.WriteLine("no ingreso una forma de pago correcta");
                }
            }
            else
            {
                Console.WriteLine("no ingreso un valor valido.");
            }
            double montoDescuento = montoRecargo * descuento;
            Console.WriteLine($"monto de descuento: {montoDescuento:F2}");
            Console.WriteLine($"descuento de: {descuento:F2}");

            Console.ReadKey();
        }


        static char inputKey()
        {
            char input = char.ToUpper(Console.ReadKey(true).KeyChar);
            return input;
        }
    }
}
