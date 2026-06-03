class Program
{
    static void Main()
    {
        Console.Write("ingrese un numero: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero >= 0)
            Console.WriteLine("el numero es POSITIVO");
        else
            Console.WriteLine("el numero es NEGATIVO");

        string resultado = numero >= 0? "POSITIVO" : "NEGATIVO";
        Console.WriteLine($"con operador ternario: el numero es {resultado}");
    }
}