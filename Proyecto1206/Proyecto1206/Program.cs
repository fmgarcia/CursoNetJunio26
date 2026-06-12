bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════╗");
    Console.WriteLine("║     CALCULADORA BÁSICA   ║");
    Console.WriteLine("╠══════════════════════════╣");
    Console.WriteLine("║  1. Suma                 ║");
    Console.WriteLine("║  2. Resta                ║");
    Console.WriteLine("║  3. Multiplicación       ║");
    Console.WriteLine("║  4. División             ║");
    Console.WriteLine("║  5. Salir                ║");
    Console.WriteLine("╚══════════════════════════╝");
    Console.Write("\nSelecciona una opción: ");

    string opcion = Console.ReadLine() ?? string.Empty;

    if (opcion == "5")
    {
        salir = true;
        Console.WriteLine("\nHasta luego!");
        break;
    }

    if (opcion is not ("1" or "2" or "3" or "4"))
    {
        Console.WriteLine("\nOpción no válida. Pulsa una tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    Console.Write("Introduce el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("\nNúmero no válido. Pulsa una tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    Console.Write("Introduce el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("\nNúmero no válido. Pulsa una tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    double resultado;
    string operacion;

    switch (opcion)
    {
        case "1":
            resultado = num1 + num2;
            operacion = "+";
            break;
        case "2":
            resultado = num1 - num2;
            operacion = "-";
            break;
        case "3":
            resultado = num1 * num2;
            operacion = "×";
            break;
        case "4":
            if (num2 == 0)
            {
                Console.WriteLine("\nError: no se puede dividir entre cero.");
                Console.WriteLine("Pulsa una tecla para continuar...");
                Console.ReadKey();
                continue;
            }
            resultado = num1 / num2;
            operacion = "÷";
            break;
        default:
            continue;
    }

    Console.WriteLine($"\nResultado: {num1} {operacion} {num2} = {resultado}");
    Console.WriteLine("\nPulsa una tecla para continuar...");
    Console.ReadKey();
}
