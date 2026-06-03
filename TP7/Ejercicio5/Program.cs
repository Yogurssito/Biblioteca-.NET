class Program
{
    static void Main()
    {
        Console.Write("ingrese un nombre de usuario: ");
        string usuario = Console.ReadLine();

        if (EsUsuarioValido(usuario))
            Console.WriteLine($"'{usuario}' es un nombre de usuario VALIDO.");
        else
            Console.WriteLine($"'{usuario}' es un nombre de usuario INVALIDO.");
    }

    static bool EsUsuarioValido(string usuario)
    {
        if (usuario.Contains(' ')) return false;
        if (usuario.Contains('ñ') || usuario.Contains('Ñ')) return false;
        return true;
    }
}