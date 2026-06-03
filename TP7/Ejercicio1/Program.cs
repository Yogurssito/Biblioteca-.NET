class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] notas = new int[20];

        for (int i = 0; i < 20; i++)
            notas[i] = rnd.Next(1, 11);

        Console.WriteLine("Notas generadas:");
        Console.WriteLine(string.Join(", ", notas));
        Console.WriteLine();

        int aprobados = 0, desaprobados = 0;
        int notaMaxima = notas[0], notaMinima = notas[0];
        double suma = 0;

        foreach (int nota in notas)
        {
            if (nota >= 6) aprobados++;
            else desaprobados++;
            if (nota > notaMaxima) notaMaxima = nota;
            if (nota < notaMinima) notaMinima = nota;
            suma += nota;
        }

        Console.WriteLine("=== Informe de Notas ===");
        Console.WriteLine($"Alumnos aprobados:    {aprobados}");
        Console.WriteLine($"Alumnos desaprobados: {desaprobados}");
        Console.WriteLine($"Nota mas alta:        {notaMaxima}");
        Console.WriteLine($"Nota mas baja:        {notaMinima}");
        Console.WriteLine($"Promedio:             {suma / 20}");
    }
}