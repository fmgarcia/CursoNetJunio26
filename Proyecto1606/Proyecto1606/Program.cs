using System.Data;
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

        static void Ejercicio5()
        {
            Console.WriteLine("Dime tu fecha de nacimiento por orden de día, mes y año: ");
            int numSuerte = Convert.ToInt32(Console.ReadLine()) + Convert.ToInt32(Console.ReadLine())
                + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tu número de la suerte es: {numSuerte / 1000 + (numSuerte % 1000) / 100
                + (numSuerte % 100) / 10 + numSuerte % 10}");
        }
        static void Ejercicio5b()
        {
            Console.WriteLine("Vamos a calcular tu número de la suerte: ");
            Console.WriteLine("Introduce tu día de nacimiento: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce tu mes de nacimiento: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce tu año de nacimiento: ");
            int anyo = Convert.ToInt32(Console.ReadLine());
            int numSuerte = dia + mes + anyo;
            Console.WriteLine($"Tu número de la suerte es: {numSuerte / 1000 + (numSuerte % 1000) / 100
                + (numSuerte % 100) / 10 + numSuerte % 10}");
        }
        static void Ejercicio5c()
        {
            Console.WriteLine("Dime tu fecha de nacimiento por orden de día, mes y año (separados por espacios): ");
            string[] fecha = Console.ReadLine()!.Split(' ');  // ["12", "06", "1990"]
            int dia = Convert.ToInt32(fecha[0]);
            int mes = Convert.ToInt32(fecha[1]);
            int anyo = Convert.ToInt32(fecha[2]);
            int numSuerte = dia + mes + anyo;
            Console.WriteLine($"Tu número de la suerte es: {numSuerte / 1000 + (numSuerte % 1000) / 100
                + (numSuerte % 100) / 10 + numSuerte % 10}");
        }
        static void Ejercicio5d()
        {
            Console.WriteLine("Dime tu fecha de nacimiento por orden de día, mes y año (dd/mm/aaaa): ");
            string[] fecha = Console.ReadLine()!.Split('/');  // ["12", "06", "1990"]
            int dia = Convert.ToInt32(fecha[0]);
            int mes = Convert.ToInt32(fecha[1]);
            int anyo = Convert.ToInt32(fecha[2]);
            int numSuerte = dia + mes + anyo;
            Console.WriteLine($"Tu número de la suerte es: {numSuerte / 1000 + (numSuerte % 1000) / 100
                + (numSuerte % 100) / 10 + numSuerte % 10}");
        }

        static void Ejercicio5e()
        {
            Console.WriteLine("Dime tu fecha de nacimiento por orden de día, mes y año (dd/mm/aaaa): ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            int numSuerte = fecha.Day + fecha.Month + fecha.Year;
            Console.WriteLine($"Tu número de la suerte es: {numSuerte / 1000 + (numSuerte % 1000) / 100
                + (numSuerte % 100) / 10 + numSuerte % 10}");
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Introduce tu edad para saber cuantos tendras en 15 años:");
            string edad = Console.ReadLine()!;
            Console.WriteLine($"Tu edad dentro de 15 años sera: {int.Parse(edad) + 15} años");

        }

        static void PruebaCaracteres()
        {
            Console.WriteLine("Gano 1000 €");
        }

        static void Ejercicio7()
        {
            Console.WriteLine("Vas a decirme tres productos y sus precios (Con dos decimales).");
            Console.Write("Nombre del primer producto: ");
            string prod1 = Console.ReadLine();
            Console.Write("Precio del primer producto: ");
            double prod1pre = Double.Parse(Console.ReadLine());
            Console.Write("Nombre del segundo producto: ");
            string prod2 = Console.ReadLine();
            Console.Write("Precio del segundo producto: ");
            double prod2pre = Double.Parse(Console.ReadLine());
            Console.Write("Nombre del tercer producto: ");
            string prod3 = Console.ReadLine();
            Console.Write("Precio del tercer producto: ");
            double prod3pre = Double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{"NOMBRE",-15}{"PRECIO",12}{"CON IVA",13}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{prod1,-15}{prod1pre,12:F2}€{prod1pre * 1.21,12:F2}€");
            Console.WriteLine($"{prod2,-15}{prod2pre,12:F2}€{prod2pre * 1.21,12:F2}€");
            Console.WriteLine($"{prod3,-15}{prod3pre,12:F2}€{prod3pre * 1.21,12:F2}€");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{"NOMBRE".PadRight(15)}{"PRECIO".PadLeft(12)}{"CON IVA".PadLeft(13)}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{prod1.PadRight(15)}{prod1pre,12:F2}€{prod1pre * 1.21,12:F2}€");
            Console.WriteLine($"{prod2.PadRight(15)}{prod2pre,12:F2}€{prod2pre * 1.21,12:F2}€");
            Console.WriteLine($"{prod3.PadRight(15)}{prod3pre,12:F2}€{prod3pre * 1.21,12:F2}€");
        }

        static void Ejercicio8()
        {
            Console.WriteLine("Intoduce 3 numeros para realizar la suma");
            string num1 = Console.ReadKey(true).KeyChar.ToString();
            string num2 = Console.ReadKey(true).KeyChar.ToString();
            string num3 = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine($"Has escrito {num1}, {num2} y {num3} y la suma da : {int.Parse(num1) + int.Parse(num2) + int.Parse(num3)}");
        }

        static void Ejercicio9()
        {
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine() ?? string.Empty;
            Console.Write("Introduce tu edad: ");
            string edad = Console.ReadLine() ?? string.Empty;
            //Console.WriteLine($"Estos son tus datos\n\tnombre: {nombre}\n\tedad: {edad}");
            Console.WriteLine($"""
                Estos son tus datos
                    nombre: {nombre}
                    edad: {edad}
                """);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio4b();
            //Ejercicio4c();
            //Ejercicio4d();
            //Ejercicio5();
            //Ejercicio5b();
            //Ejercicio5c();
            //Ejercicio5d();
            //Ejercicio5e();
            //PruebaCaracteres();
            //Ejercicio7();
            //Ejercicio8();
            Ejercicio9();
        }
    }
}
