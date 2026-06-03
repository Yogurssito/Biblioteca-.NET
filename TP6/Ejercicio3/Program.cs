class Program
{
    static void Main()
    {
        bool acceso = Login();
        if (acceso)
            Console.WriteLine("acceso concedido.");
        else
            Console.WriteLine("acceso denegado. Se agotaron los intentos.");
    }

    static bool Login()
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("contrasena: ");
            string contraseña = Console.ReadLine();

            if (usuario == "admin" && contraseña == "1234")
                return true;

            intentos++;
            int restantes = 3 - intentos;
            if (restantes > 0)
                Console.WriteLine($"credenciales incorrectas. Intentos restantes: {restantes}");
        }
        return false;
    }
}