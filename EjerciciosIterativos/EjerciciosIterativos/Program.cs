using System.IO.Pipelines;
using System.Runtime.Intrinsics.X86;

namespace EjerciciosIterativos
{
    internal class Program
    {

        static void Ejercicio1()
        {
            // Parte While
            int i = 20;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            // Parte For
            for (int j = 20; j >= 1; j--)
            {
                Console.WriteLine(j);
            }
        }
        static void Ejercicio2()
        {
            int total = 0;
            int anadido = 0;
            do
            {
                Console.WriteLine("Indica el número que quieras sumar al total (añade 0 para terminar):");
                anadido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Total acumulado: {total += anadido}");
            } while (anadido != 0);
        }

        //Pide al usuario un número y calcula cuantas cifras tiene dicho número.Para ello
        //puedes dividir el número entre 10 hasta que el resultado sea cero.
        static void Ejercicio3()
        {
            Console.WriteLine("Dime un número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = num;
            int counter = 0;
            while (num != 0)
            {
                num = num / 10;
                counter++;
            }
            Console.WriteLine($"El número {num2} tiene {counter} cifras.");
        }

        // Pide al usuario un número y dibuja una línea con tantos asteriscos como el número introducido.
        static void Ejercicio4()
        {
            Console.WriteLine("Da un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
        }
        // Muestra los números del 1 al 30 menos los divisibles entre 3 (resto da cero).
        static void Ejercicio5()
        {
            for (int i = 1; i <= 30; i++)
                if (i % 3 != 0)
                    Console.WriteLine(i);
        }
        // Muestra de 5 en 5, los números del 0 al 100.
        static void Ejercicio6()
        {
            for (int i = 0; i <= 100; i += 5)
                Console.WriteLine(i);
        }
        //Pregunta al usuario un número y muestra del 1 hasta ese número, en una misma línea,
        //separados por comas(debes comprobar cuando es el último y no poner una coma en
        //ese caso).
        //Dime un número: 7
        //1,2,3,4,5,6,7
        static void Ejercicio7()
        {
            Console.WriteLine("Introduce un número");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + (i != num ? "," : ""));
            }
        }
        static void Ejercicio7b()
        {
            Console.WriteLine("Introduce un número");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= num; i++)
            {
                if (i != num)
                {
                    Console.Write(i + ",");
                }
                else  // Si es el último número, no ponemos la coma (i == num)
                {
                    Console.Write(i);
                }
            }
        }
        static void Ejercicio7c()
        {
            Console.WriteLine("Introduce un número");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Join(",", Enumerable.Range(1, num)));  // Utilizamos LINQ para generar la secuencia de números y luego los unimos con comas
        }
        static void Ejercicio8()
        {

        }
        static void Ejercicio9()
        {

        }
        static void Ejercicio10()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j);
                }
            }
        }

        // Escribe los números del 1 al 9, después del 1 al 8, del 1 al 7, y así sucesivamente en líneas diferentes.
        static void Ejercicio11()
        {
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        //Pide al usuario un número y dibuja un cuadrado(mismo alto que ancho) con asteriscos
        //según el número recibido.
        //Dime un número: 4
        //****
        //****
        //****
        //****
        static void Ejercicio12()
        {
            Console.WriteLine("Teclea un número:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //Pide al usuario un número y dibuja una escalera de bajada con asteriscos. La base será
        //igual al número recibido.
        //Dime un número: 4
        //*
        //**
        //***
        //****
        static void Ejercicio13()
        {
            Console.WriteLine("Dime un número:");
            int ancho_max = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ancho_max; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        //Haz lo mismo pero con una escalera de subida
        //(para generar los huecos debes escribir el carácter de espacio).
        //Dime un número: 4
        //   *
        //  **
        // ***
        //****
        static void Ejercicio14()
        {
            Console.WriteLine("Da un número entero para la altura: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                    Console.Write(j <= num - i ? " " : "*");
                Console.WriteLine();
            }
        }
        static void Ejercicio15()
        {

        }
        static void Ejercicio16()
        {

        }
        static void Ejercicio17()
        {

        }
        static void Ejercicio18()
        {

        }
        static void Ejercicio19()
        {

        }

        // Dada la siguiente contraseña propuesta por el usuario 1a; te saque 4D.
        // a los números les sume 3 (pero siempre da un número entre 0 y 9)
        // y a las letras les sume 3 , si es mayúscula que se convierta en minúscula y viceversa pero siempre que sea letra. De manera circular, es decir, si es una letra y le sumas 3 y se pasa de z o Z, que vuelva a empezar desde a o A.
        // Los signos de puntuación los cambia con el siguiente de la siguiente forma ( -> ) , ) -> - , - -> _ , _ -> = , = -> + , + -> * , * -> / , / -> ? , ? -> ! , ! -> @ , @ -> # , # -> $ , $ -> % , % -> & , & -> ' , ' -> " , " -> ; , ; -> : , : -> < , < -> > , > -> . , . -> , , , -> (

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
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            //Ejercicio13();
            Ejercicio14();
            //Ejercicio15();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
        }
    }
}
