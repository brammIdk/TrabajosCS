using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBorrar
{
    public class Draw
    {
        public static void Square(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("■ ");
                }
                Console.Write("\n");
            }

        }
        public static void IsoscelesIzq(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("■ ");
                }
                Console.Write("\n");
            }
        }
        public static void IsoscelesDer(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("  ");
                }
                for (int block = 0; block > row; block++)
                {
                    Console.Write("■ ");
                }
                Console.Write("\n");
            }

        }
        /*public static void Rombo(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("  ");
                }
                
                Console.Write("\n");
            }

        }*/
    }
}
