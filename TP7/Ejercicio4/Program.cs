class Program
{
    static void Main()
    {
        Console.Write("ingrese una frase: ");
        string frase = Console.ReadLine();

        int vocales = 0;
        int espacios = 0;
        string listaVocales = "aeiouAEIOU";

        foreach (char c in frase)
        {
            if (listaVocales.Contains(c)) vocales++;
            if (c == ' ') espacios++;
        }

        string sinEspacios = frase.Replace(" ", "");

        Console.WriteLine($"Cantidad de vocales:   {vocales}");
        Console.WriteLine($"Cantidad de espacios:  {espacios}");
        Console.WriteLine($"Frase sin espacios:    {sinEspacios}");
    }
}