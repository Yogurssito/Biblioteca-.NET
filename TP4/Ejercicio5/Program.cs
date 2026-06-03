class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int secreto = rnd.Next(1, 51);
        int intentos = 0;
        bool adivinado = false;

        Console.WriteLine("adivina el numero secreto entre 1 y 50,tenes 5 intentos.");

        while (intentos < 5 && adivinado)
        {
            Console.Write($"intento {intentos + 1}/5: ");
            int intento = int.Parse(Console.ReadLine());
            int diferencia = Math.Abs(secreto - intento);
            intentos++;

            if (intento == secreto)
            {
                Console.WriteLine($"IDOLO! Adivinaste en {intentos} intento(s).");
                adivinado = true;
            }
            else if (diferencia > 20)
                Console.WriteLine("Frio");
            else if (diferencia > 10)
                Console.WriteLine("Tibio");
            else
                Console.WriteLine("Caliente");
        }

        if (!adivinado)
            Console.WriteLine($"perdiste, el numero secreto era: {secreto}");
    }
}