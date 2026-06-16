using System.Numerics;

namespace Proyecto1606
{
    internal class Program
    {

        static void Ejercicio1()
        {
            Console.WriteLine("Dime tu usuario:");
            string nombre = Console.ReadLine()!;
            System.Console.WriteLine($"Hola {nombre}");
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Dime un número entero");
            string numero_cadena = Console.ReadLine()!;
            int numero = int.Parse(numero_cadena);
            int numero2 = Convert.ToInt32(numero_cadena);
            int numero3 = int.TryParse(numero_cadena, out int resultado) ? resultado : 0;
            Console.WriteLine($"El doble de {numero} es {2 * numero} y el triple es {3 * numero}.");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Dime una temperatura en ºC: ");
            double gradosC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La temperatura en grados Fahrenheit es {32 + (9 * gradosC / 5):F2}");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Dime un número de 3 cifras: ");
            string numero = Console.ReadLine()!;
            int num = int.Parse(numero);  // 123
            int centenas = num / 100; // 123 / 100 = 1
            int decenas = (num / 10) % 10; // (123 / 10) % 10 = 12 % 10 = 2
            int unidades = num % 10; // 123 % 10 = 3
            Console.WriteLine($"El número {num} tiene {centenas} centenas, {decenas} decenas y {unidades} unidades.");
        }
        static void Ejercicio4b()
        {
            Console.WriteLine("Dime un número de 3 cifras: ");
            int numero = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine($"El número {numero} tiene {numero / 100} centenas, " +
                $"{(numero / 10) % 10} decenas y {numero % 10} unidades.");
        }
        static void Ejercicio4c()
        {
            Console.WriteLine("Dime un número de 3 cifras: ");
            string numero_cadena = Console.ReadLine()!; // "123" -> numero_cadena[0] = '1', numero_cadena[1] = '2', numero_cadena[2] = '3'
            Console.WriteLine($"El número {numero_cadena} tiene {numero_cadena[0]} centenas, " +
                $"{(numero_cadena[1])} decenas y {numero_cadena[2]} unidades.");
        }

        static void Ejercicio4d()
        {
            Console.WriteLine("Dime un número de 3 cifras: ");
            string numero = Console.ReadLine()!;
            int num = int.Parse(numero);  // 123
            int centenas = num / 100; // 123 / 100 = 1
            num = num - centenas * 100; // 123 - 1 * 100 = 23
            int decenas = num / 10; // (23 / 10) = 2
            num = num - decenas * 10; // 23 - 2 * 10 = 3
            int unidades = num; // = 3
            Console.WriteLine($"El número {numero} tiene {centenas} centenas, {decenas} decenas y {unidades} unidades.");
        }

        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio4b();
            //Ejercicio4c();
            Ejercicio4d();
        }
    }
}
