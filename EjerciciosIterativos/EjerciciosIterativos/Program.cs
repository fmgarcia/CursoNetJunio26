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
        static void Ejercicio11()
        {

        }
        static void Ejercicio12()
        {

        }
        static void Ejercicio13()
        {

        }
        static void Ejercicio14()
        {

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
            //Ejercicio14();
            //Ejercicio15();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
        }
    }
}
