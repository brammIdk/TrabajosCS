using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01102502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la base: ");
            int nBase = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el exponente: ");
            int nExp = int.Parse(Console.ReadLine());

            int cont = 1, res = 1;
            while (cont <= nExp)
            {
                res *= nBase;
                cont++;
            }
            Console.WriteLine(res);
        }
    }
}
