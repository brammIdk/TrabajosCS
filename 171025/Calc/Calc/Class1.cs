using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Class1
    {
        public static void OutSuma(int a, int b, out double res)
        {
            res = a + b;
        }
        public static void OutResta(int a, int b, out double res)
        {
            res = a - b;
        }
        public static void OutMultiplicacion(int a, int b, out double res)
        {
            res = a * b;
        }
        public static void OutDivision(int a, int b, out double res)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Error. Division entre 0.");
                res = 0;
            }

            res = a / b;
        }

    }

}
