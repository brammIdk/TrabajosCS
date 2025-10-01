using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01102501
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, suma = 1;
            while(num <= 5)
            {
                Console.WriteLine($"numero: {num:D}");
                suma *= num ;
                num++;

            }
            Console.WriteLine($"sumas: {suma}");
            /*int result = 0;
            int numb = int.Parse(Console.ReadLine());
            for (int i = numb; i > 0; i--)
            {
                result += i;
            }
            Console.WriteLine(result);*/
        }
    }
}
