class Program
{
    static void Main()
    {
        Console.Write("ingrese la cantidad de horas: ");
        double horas = double.Parse(Console.ReadLine());
        double minutos = horas * 60;
        double segundos = horas * 3600;
        Console.WriteLine($"{horas} hora(s) = {minutos} minutos");
        Console.WriteLine($"{horas} hora(s) = {segundos} segundos");
    }
}