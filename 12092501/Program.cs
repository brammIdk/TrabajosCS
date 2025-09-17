using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12092501
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la puntuacion del examen: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 11.5)
            {
                Console.WriteLine("estas aprobado! ");
            }
            else 
            {
                Console.WriteLine("Rreprobado! ");
            }
            Console.ReadKey();
        }
    }
}
