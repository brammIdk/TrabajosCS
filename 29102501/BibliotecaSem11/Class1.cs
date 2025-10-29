using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSem11
{
    public class FDUArreglos
    {
        public static void Registrar(int[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"ingrese registro {i + 1}:");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Listar(int[] notas)
        {
            Console.WriteLine("Lista de Valores:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"nota {i} = {notas[i]}");
            }
        }
        public static void Buscar(int[] notas)
        {
            Console.WriteLine("Ingrese el valor a Buscar");
            int vBuscar = int.Parse(Console.ReadLine());
            int idx = -1;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == vBuscar)
                {
                    idx = i;
                    break;
                }
                if (idx >= 0)
                {
                    Console.WriteLine($"Encontrado el {notas[idx]}");
                }
                else
                {
                    Console.WriteLine("No encontrado");
                }
            }
        }
    }
}
