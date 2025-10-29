using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBorrar
{
    public class Array
    {

        static int[] notas = new int[10];
        private static int _contNotas = 0;
        public static void AddNota(int val)
        {
            if (_contNotas < notas.Length)
            {
                notas[_contNotas] = val;
                _contNotas++;
            }
            else
            {
                throw new Exception("valor excedido");
            }
        }
        public static int[] getNotas()
        {
            return notas;
        }
        public static void ShowNotas()
        {
            foreach (int nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
        public static int[] BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;

                    }

                }
            }
                return nums;
        }
    }
}
