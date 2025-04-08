using System;

partial class Program
{
    static void Main()
    {
        bool continuar = true;
        
        Console.WriteLine(":: Calculadora");
        
        while (continuar)
        {
            try
            {
                Console.Write("\n:: Ingresa el primer número: ");
                double num1 = LeerNumero();

                Console.Write(":: Elige operación (+,-,*,/): ");
                char operacion = LeerOperacion();

                Console.Write(":: Ingresa el segundo número: ");
                double num2 = LeerNumero();

                double resultado = Calcular(num1, num2, operacion);
                Console.WriteLine($"\n:: Resultado: {num1} {operacion} {num2} = {resultado}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n:: Error: {ex.Message}");
            }

            Console.Write(":: ¿Quieres hacer otra operación? (s/n): ");
            continuar = Console.ReadLine()!.Trim().ToLower() == "s";  // Corregido
        }
        
        Console.WriteLine("\n:: Hasta luego!");
    }

    static double LeerNumero()
    {
        string input = Console.ReadLine()!;  // "!" aquí también por si acaso
        if (!double.TryParse(input, out double numero))
        {
            throw new ArgumentException(":: ¡Ingresa un número válido!");
        }
        return numero;
    }

    static char LeerOperacion()
    {
        char op = Console.ReadKey().KeyChar!;  // Corregido
        Console.WriteLine();
        return op switch
        {
            '+' or '-' or '*' or '/'=> op,
            _ => throw new ArgumentException(":: Operación no válida. Usa +, -, *, /")
        };
    }

    static double Calcular(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => throw new InvalidOperationException("Operación no implementada")
        };
    }
}
