using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17092501
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            Console.WriteLine("ingrese un caracter");
            caracter = Console.ReadKey().KeyChar;
            caracter = char.ToLower(caracter);
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u') 
            {             
                Console.WriteLine($"\n'{caracter}' es una vocal");
            }
            else
            {
                Console.WriteLine($"\n'{caracter}' no es una vocal.");
            }
                Console.ReadKey();
        }
    }
}
