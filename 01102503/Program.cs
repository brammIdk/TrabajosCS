using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01102503
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---ingrese numeros---");
            Console.WriteLine("presione 'q' para salir");
            long maj = 0, min = 0, cont = 0;
            bool salir = false;
            while(salir != true)
            { 
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                long inNum = long.Parse(input);
                    if (cont != 1)
                    {
                        min = inNum;
                        cont++;
                    }
                    if (inNum >= maj)
                    {
                        maj = inNum;
                    }
                    else if (inNum < min)
                    {
                        min = inNum;
                    }
                }
            }
            Console.WriteLine("numero mayor: " + maj);
            Console.WriteLine("numero menor: " + min);
        }
    }
}
