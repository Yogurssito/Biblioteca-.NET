class Program
{
    static void Main()
    {
        int[] asistencia = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"ingrese asistencia del dia {i + 1}: ");
            asistencia[i] = int.Parse(Console.ReadLine());
        }

        int total = 0;
        int indiceMayor = 0, indiceMenor = 0;

        for (int i = 0; i < 15; i++)
        {
            total += asistencia[i];
            if (asistencia[i] > asistencia[indiceMayor]) indiceMayor = i;
            if (asistencia[i] < asistencia[indiceMenor]) indiceMenor = i;
        }

        double promedio = (double)total / 15;

        Console.WriteLine();
        Console.WriteLine("=== Informe de Asistencia ===");
        Console.WriteLine($"Total de alumnos presentes (15 dias): {total}");
        Console.WriteLine($"Promedio de asistencia:               {promedio}");
        Console.WriteLine($"Dia con mayor asistencia: dia {indiceMayor + 1} ({asistencia[indiceMayor]} alumnos)");
        Console.WriteLine($"Dia con menor asistencia: dia {indiceMenor + 1} ({asistencia[indiceMenor]} alumnos)");
    }
}