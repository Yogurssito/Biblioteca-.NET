class Program
{
    static void Main()
    {
        double suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"ingrese la nota {i}: ");
            double nota = double.Parse(Console.ReadLine());
            suma += nota;
        }
        double promedio = suma / 5;
        Console.WriteLine($"el promedio final del estudiante es: {promedio}");
    }
}