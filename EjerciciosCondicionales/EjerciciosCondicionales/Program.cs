using System.Runtime.ConstrainedExecution;

namespace EjerciciosCondicionales
{
    internal class Program
    {

        //Programa que lea un número entero por teclado y calcule si es par o impar.Un número
        //es par si el resto(%) de dividir entre 2 da 0.
        static void Ejercicio1()
        {
            Console.WriteLine("Dime un número entero:");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} es un número par.");
            }
            else
            {
                Console.WriteLine($"{numero} es un número impar.");
            }
        }

        // Programa que lea un número entero y muestre si el número es múltiplo de 10 (si el
        // resto de la división entre 10 da 0).
        static void Ejercicio2()
        {
            Console.WriteLine("Dime un número entero:");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            if (numero % 10 == 0)
            {
                Console.WriteLine($"{numero} es un número múltiplo de 10.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número múltiplo de 10.");
            }
        }

        //Programa que lea un carácter por teclado y compruebe si es una letra mayúscula.Una
        //letra mayúscula es aquella que está entre la ‘A’ y la ‘Z’. Recuerda que se pueden
        //comparar los caracteres como si fueran números.
        //Utiliza Console.ReadKey para leer un carácter.
        static void Ejercicio3()
        {
            Console.WriteLine("Presiona un caracter: ");
            char character = Console.ReadKey(true).KeyChar;

            if (character >= 'A' && character <= 'Z')
            {
                Console.WriteLine("El caracter es mayúscula");
            }
            else
            {
                Console.WriteLine("El caracter no es mayúscula");
            }
        }
        static void Ejercicio3a()
        {
            Console.WriteLine("Presiona un caracter: ");
            char character = Console.ReadKey(true).KeyChar;
            Console.WriteLine($"El caracter {(character >= 'A' && character <= 'Z' ? "sí " : "no ")}es mayúscula");
        }
        static void Ejercicio3a2()
        {
            Console.WriteLine("Presiona un caracter: ");
            char character = Console.ReadKey(true).KeyChar;
            Console.WriteLine($"El caracter {(character < 'A' || character > 'Z' ? "no " : "sí ")}es mayúscula");
        }
        static void Ejercicio3b()
        {
            Console.WriteLine("Presiona un caracter: ");
            char character = Console.ReadKey(true).KeyChar;

            if (character >= 'A')
            {
                if (character <= 'Z')
                {
                    Console.WriteLine("El caracter es mayúscula");
                }
                else
                {
                    Console.WriteLine("El caracter no es mayúscula");
                }
            }
            else
            {
                Console.WriteLine("El caracter no es mayúscula");
            }
        }
        static void Ejercicio3Pablo()
        {
            Console.WriteLine("Escriba una letra: ");
            char letra = Convert.ToChar(Console.ReadKey(true).KeyChar);
            string tipo = letra switch
            {
                >= 'A' and <= 'Z' => "es mayúscula",
                >= 'a' and <= 'z' => "es minúscula",
                _ => "no es una letra"
            };
            Console.WriteLine($"{letra} {tipo}");
        }
        static void Ejercicio3PabloVariante()
        {
            Console.WriteLine("Escriba una letra: ");
            char letra = Convert.ToChar(Console.ReadKey(true).KeyChar);
            string tipo = letra switch
            {
                _ when (letra >= 'A' && letra <= 'Z') => "es mayúscula",
                _ when (letra >= 'a' && letra <= 'z') => "es minúscula",
                _ => "no es una letra"
            };
            Console.WriteLine($"{letra} {tipo}");
        }

        // Programa que le pida 2 cadenas de texto al usuario y compruebe si son iguales
        static void Ejercicio4()
        {
            Console.WriteLine("Dame tu usuario: ");
            string usuario1 = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Confirma tu usuario: ");
            string usuario2 = Console.ReadLine() ?? string.Empty;
            if (usuario1.Equals(usuario2))  // usuario1 == usuario2  // usuario1.Equals(usuario2, StringComparison.OrdinalIgnoreCase) para ignorar mayúsculas/minúsculas
            {
                Console.WriteLine("Los usuarios coinciden.");
            }
            else
            {
                Console.WriteLine("Los usuarios no coinciden.");
            }
        }

        //Programa que lea dos números por teclado y muestre el resultado de la división del
        //primer número por el segundo.Se debe comprobar que el divisor no puede ser cero.
        static void Ejercicio5()
        {
            Console.WriteLine("Dame el dividendo: ");
            int numero1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Dame el divisor: ");
            int numero2 = int.Parse(Console.ReadLine()!);
            if (numero2 != 0)
            {
                double resultado = (double)numero1 / numero2;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            else
            {
                Console.WriteLine("El divisor no puede ser cero.");
            }
        }
        // Programa que pida al usuario tres números enteros y muestre el mayor de los tres.
        static void Ejercicio6()
        {
            Console.Write("Introduce el primer número entero: ");
            if (!int.TryParse(Console.ReadLine(), out int n1))
            {
                Console.WriteLine("Entrada inválida: el primer valor no es un entero.");
                return;
            }
            Console.Write("Introduce el segundo número entero: ");
            if (!int.TryParse(Console.ReadLine(), out int n2))
            {
                Console.WriteLine("Entrada inválida: el segundo valor no es un entero.");
                return;
            }
            Console.Write("Introduce el tercer número entero: ");
            if (!int.TryParse(Console.ReadLine(), out int n3))
            {
                Console.WriteLine("Entrada inválida: el tercer valor no es un entero.");
                return;
            }

            // Forma 1: Usando if-else
            //if(n1>=n2 && n1 >= n3)
            //{
            //    Console.WriteLine($"El mayor es: {n1}");
            //}
            //else if (n2 >= n1 && n2 >= n3)
            //{
            //    Console.WriteLine($"El mayor es: {n2}");
            //}
            //else
            //{
            //    Console.WriteLine($"El mayor es: {n3}");
            //}

            // Forma 2: Usando una variable para almacenar el mayor
            //int mayor = n1;
            //if (n2 > mayor) mayor = n2;
            //if (n3 > mayor) mayor = n3;
            //Console.WriteLine($"El mayor de {n1}, {n2} y {n3} es {mayor}.");

            // Forma 3: Usando Math.Max
            //int mayor = Math.Max(n1, Math.Max(n2, n3));
            //Console.WriteLine($"El mayor de {n1}, {n2} y {n3} es {mayor}.");

            // Forma 4: Usando el operador ternario
            int mayor = (n1 >= n2 && n1 >= n3) ? n1 : (n2 >= n1 && n2 >= n3) ? n2 : n3;
            Console.WriteLine($"El mayor de {n1}, {n2} y {n3} es {mayor}.");

        }

        static void Ejercicio7()
        {
            Console.Write("Introduce la hora (0-23): ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce los minutos (0-59): ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce los segundos (0-59): ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            if (horas >= 0 && horas <= 23 &&
                minutos >= 0 && minutos <= 59 &&
                segundos >= 0 && segundos <= 59)
            {
                Console.WriteLine($"Hora válida: {horas:D2}:{minutos:D2}:{segundos:D2}");
            }
            else
            {
                Console.WriteLine("Error: hora, minutos o segundos fuera de rango.");
            }
        }
        static void Ejercicio8()
        {
            Console.WriteLine("Dime un número:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El número {num} es {(num % 2 == 0 ? "par" : "impar")}");
        }
        static void Ejercicio9()
        {

        }
        static void Ejercicio10()
        {

        }
        static void Ejercicio11()
        {

        }
        static void Ejercicio12()
        {

        }



        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            Ejercicio8();
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
        }
    }
}
