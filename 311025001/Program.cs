using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _311025002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new String[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"ingrese el valor para el indice {i}: ");
                nombre[i] = Console.ReadLine();
            }
            Console.WriteLine($"Mostrando los valores almacenados");
            foreach (string n in nombre)
            {
                Console.WriteLine(n);
            }
        }
    }
}
