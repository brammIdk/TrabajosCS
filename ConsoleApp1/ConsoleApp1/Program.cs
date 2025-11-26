using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejc01();
        }
        static void Ejc01()
        {
            int[,] Matriz = new int[10, 7];
            //LlenarMatriz(Matriz);
            MostrarMatriz(Matriz);
            Console.ReadKey();
        }

        static void LlenarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Ingrese valor [{i},{c}]:");
                    matriz[i, c] = int.Parse(Console.ReadLine());
                }
            }

        }


        static void MostrarMatriz(int[,] matriz)
        {
            const int space = 10;
            int numLetters = 8;

            MostrarCasilleroSup();
            MostraContenido();
            MostrarCasilleroInf();


            //centro
            void MostraContenido()
            {
                
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int c = 0; c < matriz.GetLength(1); c++)
                    {

                        Console.Write($"  ║[{i},{c}] = {matriz[i, c],space}║\t");
                    }
                    Console.WriteLine();
                    MostrarCasilleros();
                }
            }
            void MostrarCasilleros()
            {

                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    Console.Write("  ╠");
                    for (int k = 0; k < numLetters + space; k++)
                    {
                        Console.Write("═");
                    }
                    Console.Write("╣");
                    //espaciado
                    Console.Write("\t");
                }

                Console.WriteLine();

            }

            //superior e inferior
            void MostrarCasilleroSup()
            {
            
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    Console.Write("  ╔");
                    for (int k = 0; k < numLetters + space; k++)
                    {
                        Console.Write("═");
                    }
                    Console.Write("╗");
                    //espaciado
                        Console.Write("\t");
                }
                
                Console.WriteLine();

            }
            void MostrarCasilleroInf()
            {
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    Console.Write("  ╚");
                    for (int k = 0; k < numLetters + space; k++)
                    {
                        Console.Write("═");
                    }
                    Console.Write("╝");
                    //espaciado
                    Console.Write("\t");
                }


            }
        }                    
        
    }
}
