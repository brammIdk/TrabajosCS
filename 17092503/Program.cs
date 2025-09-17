using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17092503
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("monto consumo: ");
            double montoConsumo = double.Parse(Console.ReadLine());
            double descuento = 1;
            //descuento
            if (montoConsumo <= 100)
            {
                descuento = 0.10;
            }
            else if (montoConsumo <= 200) 
            {
                descuento = 0.20;
            }
            else if (montoConsumo > 200)
            {
                descuento = 0.30;
            }
            //
            const double IGV = 0.18; 
            double montoDscto = montoConsumo * descuento;
            double subTotal = montoConsumo - montoDscto;
            double montoImpuesto = subTotal * IGV;
            double montoTotal = subTotal + montoImpuesto;

            Console.WriteLine($"monto de descuento: {montoDscto:F2}");
            Console.WriteLine($"subtotal: {subTotal:F2}");
            Console.WriteLine($"monto de impuesto: {montoImpuesto:F2}");
            Console.WriteLine($"monto total: {montoTotal:F2}");

            Console.ReadKey();

        }
    }
}
