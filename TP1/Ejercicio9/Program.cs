class Program
{
    static void Main()
    {
        Console.Write("ingrese la cantidad total de dias de clase: ");
        int totalDias = int.Parse(Console.ReadLine());
        Console.Write("ingrese la cantidad de asistencias del alumno: ");
        int asistencias = int.Parse(Console.ReadLine());
        double porcentaje = (double)asistencias / totalDias * 100;
        Console.WriteLine($"el porcentaje de presencialidad es: {porcentaje}%");
    }
}