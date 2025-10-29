using BibliotecaSem11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBorrar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[10];
            FDUArreglos.Registrar(notas);   
        }

        static void BsortEjerc()
        {
            int[] nums = { 2, 3, 31, 2, 3, 4, 9, 8, 7, 6, 1000, 0, -1, 700 };
            int[] res = Array.BubbleSort(nums);
            foreach (int r in res)
            {
                Console.Write(r + ", ");
            }
        }
    }
}
