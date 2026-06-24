using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //Programa que lea una variable entera llamada mes y compruebe con una estructura
        //switch, si el valor corresponde a un mes de 30 días, de 31 o de 28.Supondremos que
        //febrero tiene 28 días.Se mostrará además de los días, el nombre del mes.Se mostrará
        //un error cuando el mes no sea válido.
        static void Ejercicio9()
        {
            Console.WriteLine("Indique el número del mes: ");
            int numMes = Convert.ToInt32(Console.ReadLine());
            string mes = numMes switch
            {
                1 => "Enero, 31 días",
                2 => "Febrero, 28 días",
                3 => "Marzo, 31 días",
                4 => "Abril, 30 días",
                5 => "Mayo, 31 días",
                6 => "Junio, 30 días",
                7 => "Julio, 31 días",
                8 => "Agosto, 31 días",
                9 => "Septiembre, 30 días",
                10 => "Octubre, 31 días",
                11 => "Noviembre, 30 días",
                12 => "Diciembre, 31 días",
                _ => "Mes no válido"
            };
            Console.WriteLine(mes);
        }
        static void Ejercicio9b()
        {
            Console.WriteLine("Indique el número del mes: ");
            int numMes = Convert.ToInt32(Console.ReadLine());
            int diasMes = numMes switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 0
            };
            string nombreMes = numMes switch
            {
                1 => "Enero",
                2 => "Febrero",
                3 => "Marzo",
                4 => "Abril",
                5 => "Mayo",
                6 => "Junio",
                7 => "Julio",
                8 => "Agosto",
                9 => "Septiembre",
                10 => "Octubre",
                11 => "Noviembre",
                12 => "Diciembre",
                _ => "Mes no válido"
            };
            Console.WriteLine($"El mes {numMes} es {nombreMes} y tiene {diasMes} días");
        }

        //Crea un programa que lea una letra tecleada por el usuario y diga si se trata de un
        //signo de puntuación(. , ; :), una cifra numérica(del 0 al 9) u otro carácter, usando
        //"switch" (pista: necesitarás usar un dato de tipo "char").
        static void Ejercicio10()
        {
            Console.Write("Presiona cualquier tipo de caracter: ");
            char c = Console.ReadKey().KeyChar;
            string tipoCaracter = c switch
            {
                ':' or ';' or '.' or ',' => "es un signo de puntuacion",
                '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9' => "es un numero",
                _ => "es otro tipo de caracter"
            };
            Console.WriteLine($"\n{c} {tipoCaracter}");
        }
        static void Ejercicio10b()
        {
            Console.Write("Presiona cualquier tipo de caracter: ");
            char c = Console.ReadKey().KeyChar;
            string tipoCaracter = c switch
            {
                ':' or ';' or '.' or ',' => "es un signo de puntuacion",
                _ when c >= '0' && c <= '9' => "es un numero",
                _ when (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == 'ñ' || c == 'Ñ' => "es una letra",
                _ => "es otro tipo de caracter"
            };
            Console.WriteLine($"\n{c} {tipoCaracter}");
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
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio9b();
            //Ejercicio10();
            Ejercicio10b();
            //Ejercicio11();
            //Ejercicio12();
        }
    }
}
