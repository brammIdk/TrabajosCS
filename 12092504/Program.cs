namespace _12092504;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese la nota del estudiante: ");
        var valorPorDefecto = "0"; 
        var resultadoIntermedio = Console.ReadLine() ?? valorPorDefecto;
        var numero2 = int.Parse(resultadoIntermedio);
    }
}
