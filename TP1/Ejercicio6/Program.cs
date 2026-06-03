class Program
{
    static void Main()
    {
        Console.Write("ingrese la distancia recorrida (km): ");
        double distancia = double.Parse(Console.ReadLine());
        Console.Write("ingrese el tiempo empleado (horas): ");
        double tiempo = double.Parse(Console.ReadLine());
        double velocidad = distancia / tiempo;
        Console.WriteLine($"La velocidad promedio es: {velocidad} km/h");
    }
}