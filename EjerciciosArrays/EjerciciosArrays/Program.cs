using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosArrays
{
    internal class Program
    {

        //Crea un array con los nombres de los meses.A continuación pide al usuario un número
        //del 1 al 12. Muéstrale el nombre del mes correspondiente sin usar estructuras
        //condicionales(es decir, a partir de los valores del array).
        static void Ejercicio1()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("Dime un número entero del 1 al 12: ");
            int mes = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine($"El mes {mes} es {meses[mes - 1]}");
        }
        static void Ejercicio2()
        {
            const int LENGTH = 3;
            Console.WriteLine($"Dime {LENGTH} números:");
            int[] numeros = new int[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                Console.WriteLine($"Introduzca número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int min = int.MaxValue;  // Inicializamos min con el valor máximo posible para asegurarnos de que cualquier número ingresado será menor
            int max = int.MinValue;  // Inicializamos max con el valor mínimo posible para asegurarnos de que cualquier número ingresado será mayor
            foreach (int i in numeros)
            {
                sum += i;
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }

            Console.WriteLine($"Los números son {string.Join(", ", numeros)}");
            Console.WriteLine($"La suma de los números es {sum}");
            Console.WriteLine($"La suma de los números es {numeros.Sum()}");
            Console.WriteLine($"La media de los números es {(double)sum / LENGTH:F2}");
            Console.WriteLine($"La media de los números es {numeros.Average():F2}");
            Console.WriteLine($"El número mínimo es {min}");
            Console.WriteLine($"El número mínimo es {numeros.Min()}");
            Console.WriteLine($"El número máximo es {max}");
            Console.WriteLine($"El número máximo es {numeros.Max()}");

        }
        static void Ejercicio3()
        {

        }
        static void Ejercicio4()
        {

        }
        static void Ejercicio5()
        {

        }
        static void Ejercicio6()
        {

        }
        static void Ejercicio7()
        {

        }
        static void Ejercicio8()
        {

        }

        //Crea un array de cadenas con 10 posiciones.Pide al usuario que introduzca 10
        //nombres.Por cada nombre introducido, debes comprobar que no existe ya en el array.
        //Si existe, no lo guardes y vuelve a pedirle otro nombre.
        // Este no es bidimensional, es un array de una dimensión, pero es un ejercicio de arrays.
        static void EjercicioMultidimensionales1()
        {
            const int NUMERODENOMBRES = 3;  // Cambia este valor a 10 si quieres pedir 10 nombres
            string[] nombres = new string[NUMERODENOMBRES];
            Console.WriteLine($"Introduce {NUMERODENOMBRES} nombres. No se aceptan duplicados.");
            int count = 0;
            while (count < nombres.Length)
            {
                Console.Write($"Nombre {count + 1}: ");
                string? entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Nombre vacío. Intenta de nuevo.");
                    continue;
                }
                string nombre = entrada.Trim();  // Trim Elimina espacios en blanco al inicio y al final de la cadena
                bool existe = Array.Exists(nombres, n => n != null && n.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                if (existe)
                {
                    Console.WriteLine("Ese nombre ya existe. Escribe otro.");
                    continue;
                }
                nombres[count] = nombre;
                count++;
            }

            Console.WriteLine("\nNombres introducidos:");
            foreach (var n in nombres)
            {
                Console.WriteLine(n);
            }
        }
        static void EjercicioMultidimensionales2()
        {

        }
        static void EjercicioMultidimensionales3()
        {

        }
        static void EjercicioMultidimensionales4()
        {

        }
        static void EjercicioMultidimensionales5()
        {

        }
        static void EjercicioMultidimensionales6()
        {

        }

        // Dada la siguiente contraseña propuesta por el usuario 1a; te saque 4D.
        // a los números les sume 3 (pero siempre da un número entre 0 y 9)
        // y a las letras les sume 3 , si es mayúscula que se convierta en minúscula y viceversa pero siempre que sea letra. De manera circular, es decir, si es una letra y le sumas 3 y se pasa de z o Z, que vuelva a empezar desde a o A.
        // Los signos de puntuación los cambia con el siguiente de la siguiente forma ( -> ) , ) -> - , - -> _ , _ -> = , = -> + , + -> * , * -> / , / -> ? , ? -> ! , ! -> @ , @ -> # , # -> $ , $ -> % , % -> & , & -> ' , ' -> " , " -> ; , ; -> : , : -> < , < -> > , > -> . , . -> , , , -> (
        static void Codificar()
        {

        }


        static void Main(string[] args)
        {
            //Ejercicio1();
            Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //EjercicioMultidimensionales1();
            //EjercicioMultidimensionales2();
            //EjercicioMultidimensionales3();
            //EjercicioMultidimensionales4();
            //EjercicioMultidimensionales5();
            //EjercicioMultidimensionales6();
        }
    }
}
