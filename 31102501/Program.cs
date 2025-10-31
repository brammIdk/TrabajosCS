using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31102501
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEstudiantes ;
            double sumaCalif = 0, promedio, Cmax = 0.0, Cmin = 20.0;

            Console.WriteLine("ingrese la cantidad de alumnos: ");
            numEstudiantes = int.Parse(Console.ReadLine());

            double[] calificaciones = new double[numEstudiantes];

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine($"ingrese la nota del estudiante {i+1}");
                calificaciones[i] = double.Parse(Console.ReadLine());

                sumaCalif += calificaciones[i];
            }
            for (int i = 0; i < numEstudiantes; i++)
            {
                if (calificaciones[i] < Cmin)
                {
                    Cmin = calificaciones[i];
                }
                if (calificaciones[i] > Cmax)
                {
                    Cmax = calificaciones[i];
                }
            }
            
            promedio = sumaCalif / numEstudiantes;
            Console.WriteLine($"promedio: {promedio:F2}");
            Console.WriteLine($"calificacion minima: {Cmin}");
            Console.WriteLine($"calificacion maxima: {Cmax}");

        }
    }
}

