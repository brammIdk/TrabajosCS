using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejerc02();
        }
        static void Ejerc01()
        {
            string nombre;
            Console.WriteLine("Ingrese una cadena");
            nombre = Console.ReadLine();

            Console.WriteLine("cantidad de veces a repetir");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeat(nombre, n));
            
            PrintArr(StringSplit(nombre));

        }
        static void Ejerc02()
        {
            Console.WriteLine("Ingresa una cadena");
            string text = Console.ReadLine();
            BuscarPalabra(text, "peru");      
        }


        //string repeat sin StringBuilder
        /*static string StringRepeat(string text, int reps)
        {
            string res = "";
            for (int i = 0; i < reps; i++)
            {
                res += text;
            }
            return res;
        }*/
        static string StringRepeat(string text, int reps)
        {
            StringBuilder sb = new StringBuilder();
            string res = "";
            for (int i = 0; i < reps; i++)
            {
                sb.Append(text);
                sb.Append("\n");
            }         
            res = sb.ToString();

            return res;
        }

        static string[] StringSplit(string text)
        {
            char separator = '\n';
            string[] res = text.Split(separator);
            return res;
        }
        static string[] StringSplit(string text, char separator)
        {
            string[] res = text.Split(separator);
            return res;
        }
        static void PrintArr(string[] value)
        {
            Console.WriteLine("Texto: ");
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine($"{i+1}: {value[i]}");
            }
        }
        static void PrintWordsCount(string text)
        {
            string[] res = text.Split(' ');
            Console.WriteLine($"cantidad de palabras: {res.Length}");
        }
        static int WordsCount(string text)
        {
            string[] res = text.Split(' ');
            int value = res.Length;
            return value;
        }
        static void PrintListString()
        {
            Console.WriteLine("ingrese una oracion.");
            string text = Console.ReadLine();
            string[] res = text.Split(' ');
            Console.WriteLine("Texto: ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {res[i]}");
            }

        }
        static void PrintListString(string text)
        {
            string[] res = text.Split(' ');
            Console.WriteLine("Texto: ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {res[i]}");
            }

        }
        static void BuscarPalabra(string text, string word)
        {
            string[] res = text.Split(' ');
            bool found = true;
            string nums = "";
            for (int i = 0; i < res.Length; i++)
            {
                if (word.Equals(res[i]))
                {
                    nums = string.Concat("'",i,"'" ," ");                   
                    Console.WriteLine(nums);

                }
                else
                {
                    found = false;
                }
            }
            if (found)
            {
                Console.WriteLine($"'{word}' encontrada en la posicion: {nums}");
            }
            else
            { 
                Console.WriteLine("No se encontro la palabra");
            }

        }

    }

}
