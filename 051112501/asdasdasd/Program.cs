namespace asdasdasd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = IntInput("ingrese cantidad de elementos: ");
            
            string[] listaCiudades = new string[n];
            //llenar
            listaCiudades = Registro(listaCiudades);
            Listar(listaCiudades);
            string[] nuevaLista = Insertar(listaCiudades,"Yucatan",1);

            Listar(nuevaLista);
        }
        static string[] Registro(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Registro {(i + 1)}:");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }
        static void Listar(string[] arr)
        {
            Console.WriteLine("items:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"item {i+1}: {arr[i]}");
            }
            Console.WriteLine(" ");
        }
        static void Buscar(string[] arr, string item)
        {
            bool Found = false;
            int repeats = 0;

            Console.WriteLine("===Buscar===");
            for (int i = 0; i < arr.Length; i++)
            {
                if (item.ToLower().Equals(arr[i].ToLower()))
                {
                    Console.WriteLine($"'{item}' Encontrado en el indice '{i}'");
                    repeats++;
                    Found = true;
                }
            }
            if (!Found)
            { 
               Console.WriteLine("No se encontro el item mencionado.");
                return;
            }
            //se ejecuta si se encontro un item:
            Console.WriteLine($"cantidad de '{item}' encontrado: {repeats}\n");
        }

        static void Buscar(string[] arr)
        {
            bool Found = false;
            int repeats = 0;

            Console.WriteLine("===ingrese el valor a buscar===");
            string item = Console.ReadLine().ToLower();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (item.Equals(arr[i].ToLower()))
                {
                    Console.WriteLine($"'{item}' Encontrado en el indice '{i}'");
                    repeats++;
                    Found = true;
                }
            }
            if (!Found)
            {
                Console.WriteLine("No se encontro el item mencionado.");
                return;
            }
            //se ejecuta si se encontro un item:
            Console.WriteLine($"cantidad de '{item}' encontrado: {repeats}\n");

        }
        static string[] Insertar(string[]arr,string Value, int position)
        {
            string[] sol = new string[arr.Length+1];
            for (int i = 0; i < sol.Length; i++)
            {
                if (i == position-1)
                {
                    sol[i] = Value;
                }
                else if (i > position-1)
                {
                    sol[i] = arr[i - 1];
                }
                else
                {
                    sol[i] = arr[i];
                }
            }            
            return sol;
        }
        static int IntInput(string message)
        {
            int result = 0;

            while (true)
            { 
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input,out result))
                {
                        break;
                }
                Console.WriteLine("ingrese un valor correcto.");
            }
            return result;
        }
    }
}
