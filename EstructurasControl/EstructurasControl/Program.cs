using System.Diagnostics;

namespace EstructurasControl
{
    internal class Program
    {

        static void EjemploIf()
        {
            Console.Write("Dime tu nombre: ");
            string nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("¡El nombre no puede estar vacío!");
            }
            Console.WriteLine($"Hola {nombre}");
        }

        static void EjemploIfElse()
        {
            Console.Write("Dime tu nombre: ");
            string nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("¡El nombre no puede estar vacío!");
            }
            else
            {
                Console.WriteLine($"Hola {nombre}");
            }
            Console.WriteLine("Fin del programa");
        }

        static void EjemploIfElseIfElse()
        {
            Console.Write("Dime el prefijo de tu país: ");
            // Así se convierte una cadena a número
            int prefijo = Int32.Parse(Console.ReadLine());
            if (prefijo == 34)
            {
                Console.WriteLine("Tu país es España");
            }
            else if (prefijo == 49)
            {
                Console.WriteLine("Tu país es Alemania");
            }
            else if (prefijo == 33)
            {
                Console.WriteLine("Tu país es Francia");
            }
            else
            {
                Console.WriteLine("No sé cual es tu país...");
            }
            Console.WriteLine("Fin del programa");
        }


        static void EjemploSwitch()
        {
            Console.Write("Dime el prefijo de tu país: ");
            // Así se convierte una cadena a número
            int prefijo = Int32.Parse(Console.ReadLine());
            switch (prefijo)
            {
                case 34:
                    Console.WriteLine("Tu país es España");
                    break;
                case 49:
                    Console.WriteLine("Tu país es Alemania");
                    break;
                case 33:
                    Console.WriteLine("Tu país es Francia");
                    break;
                default:
                    Console.WriteLine("No sé cual es tu país...");
                    break;
            }
            Console.WriteLine("Fin del programa");
        }

        static void EjemploSwitchConString()
        {
            Console.Write("Dime el nombre de tu país: ");
            string pais = Console.ReadLine();
            switch (pais)
            {
                case "España":
                    Console.WriteLine("Tu prefijo es 34");
                    break;
                case "Alemania":
                    Console.WriteLine("Tu prefijo es 49");
                    break;
                case "Francia":
                    Console.WriteLine("Tu prefijo es 33");
                    break;
                default:
                    Console.WriteLine("No sé cual es tu país...");
                    break;
            }
            Console.WriteLine("Fin del programa");
        }

        static void EjemploSwitchModerno()
        {
            int dia = 3;

            string nombreDia = dia switch  // Disponible desde C# 8.0, pero en C# 14.0 se puede usar con más características
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Día inválido"   // _ es el caso por defecto (como default)
            };
            Console.WriteLine(nombreDia);  // "Miércoles"
        }

        static void EjemploAntriorSwitchClasico()
        {
            int dia = 3;
            string nombreDia = "";
            switch (dia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miércoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    nombreDia = "Día inválido";
                    break;
            }
            Console.WriteLine(nombreDia);  // "Miércoles"
        }

        static void EjemploSwitchPatternMatching()
        {
            double nota = 7.5;

            string calificacion = nota switch  // Pattern matching con switch expressions, disponible desde C# 8.0
            {
                < 0 or > 10 => "Nota inválida",
                < 5 => "Suspenso",
                < 6 => "Aprobado",
                < 7 => "Bien",
                < 9 => "Notable",
                <= 10 => "Sobresaliente",
                _ => "Error"
            };

            Console.WriteLine($"Nota {nota}: {calificacion}");  // "Nota 7.5: Notable"
        }

        // Switch pattern matching con tipos y tuplas, disponible desde C# 8.0
        // En C# 14.0 se puede usar con más características
        // Estos ejemplos solo para aquellos que quieran aprender más sobre C# 14.0 y sus características avanzadas
        // Solo para curiosos y desarrolladores avanzados
        static void EjemploSwitchPatternMatchingConTipos()
        {
            object obj = 42; // Puede ser cualquier tipo
            string resultado = obj switch
            {
                int i => $"Es un entero: {i}",
                double d => $"Es un doble: {d}",
                string s => $"Es una cadena: {s}",
                null => "Es nulo",
                _ => "Tipo desconocido"
            };
            Console.WriteLine(resultado);  // "Es un entero: 42"
        }

        static void EjemploSwitchPatternMatchingConTuplas()
        {
            (int, int) punto = (3, 4);
            string cuadrante = punto switch
            {
                (0, 0) => "Origen",
                (_, 0) => "Eje X",
                (0, _) => "Eje Y",
                (var x, var y) when x > 0 && y > 0 => "Primer cuadrante",
                (var x, var y) when x < 0 && y > 0 => "Segundo cuadrante",
                (var x, var y) when x < 0 && y < 0 => "Tercer cuadrante",
                (var x, var y) when x > 0 && y < 0 => "Cuarto cuadrante",
                _ => "Desconocido"
            };
            Console.WriteLine($"El punto {punto} está en: {cuadrante}"); // "El punto (3, 4) está en: Primer cuadrante"
        }

        // Ejemplos de ternarias
        static void EjemploTernaria()
        {
            int edad = 20;
            string mensaje = (edad >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
            Console.WriteLine(mensaje); // "Eres mayor de edad"
        }

        static void EjemploAnteriorSinTernaria()
        {
            int edad = 20;
            string mensaje;
            if (edad >= 18)
            {
                mensaje = "Eres mayor de edad";
            }
            else
            {
                mensaje = "Eres menor de edad";
            }
            Console.WriteLine(mensaje); // "Eres mayor de edad"
        }

        static void EjemploTernariaImpresion()
        {
            int num = 23;
            Console.WriteLine($"{num} es {(num % 2 == 0 ? "par" : "impar")}");
        }

        static void EjemploAnteriorSinTernariaImpresion()
        {
            int num = 23;
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} es par");
            }
            else
            {
                Console.WriteLine($"{num} es impar");
            }
        }

        static void EjemploTernariaPlurales()
        {
            int euros = 1;
            Console.WriteLine($"{(euros == 1 ? "Es" : "Son")} {euros} euro{(euros == 1 ? "" : "s")}");
        }

        static void EjemploAnteriorSinTernariaPlurales()
        {
            int euros = 1;
            if (euros == 1)
            {
                Console.WriteLine($"Es {euros} euro");
            }
            else
            {
                Console.WriteLine($"Son {euros} euros");
            }
        }


        static void EjemploWhile()
        {
            int total = 0;
            while (total < 100)
            {
                Console.Write($"Escribe un número (acumulado: {total}): ");
                int num = Convert.ToInt32(Console.ReadLine());
                total += num;
            }
            Console.WriteLine($"El total acumulado ha sido {total}");
        }
        static void EjemploDoWhile()
        {
            int total = 0;
            do
            {
                Console.Write($"Escribe un número (acumulado: {total}): ");
                int num = Convert.ToInt32(Console.ReadLine());
                total += num;
            } while (total < 100);
            Console.WriteLine($"El total acumulado ha sido {total}");
        }

        static void EjemploFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"El valor de i es {i}");
            }
        }

        static void EjemploAnteriorConWhile()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"El valor de i es {i}");
                i++;
            }
        }

        static void EjemploFor2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"El valor de i es {i}");
            }
        }
        static void EjemploFor3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hola Mundo");
            }
        }
        static void TablaDel7()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"7 x {i} = {7 * i}");
            }
        }
        static void ParesDel0Al100()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine($"{i} es par");
            }
        }

        static void CuentaAtras()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void BucleForConVariasVariables()
        {
            for (int i = 0, j = 10; i <= 10 && j >= 5; i++, j--)  // Se ejecuta 6 veces, i va de 0 a 5 y j de 10 a 5
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }

        static void EjemploBucleAnteriorConWhile()
        {
            int i = 0, j = 10;
            while (i <= 10 && j >= 5)
            {
                Console.WriteLine($"i: {i}, j: {j}");
                i++;
                j--;
            }
        }

        static void BucleForComoWhile()
        {
            int total = 0;
            for (; total < 100;)
            {
                Console.Write($"Escribe un número (acumulado: {total}): ");
                int num = Convert.ToInt32(Console.ReadLine());
                total += num;
            }
            Console.WriteLine($"El total acumulado ha sido {total}");
        }

        // Ejemplos de foreach

        static void ForEach1ConArray()
        {
            int[] array = { 9, 12, 26, 34 };
            foreach (int num in array)
            // Recorremos los números de arriba
            {
                // En cada repetición, num toma el valor del siguiente número
                Console.WriteLine(num);
            }
        }

        static void ForEach2ConArrayNombres()
        {
            string[] nombres = { "Ana", "Luis", "Pedro", "María" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Hola {nombre}");
            }
        }


        // Break y continue en bucles

        static void EjemploBreak()
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Dime un número del 1 al 10 (total {total}): ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 10)
                {
                    Console.WriteLine("Número no válido");
                    break;  // Salimos del bucle si el número no es válido
                }
                total += num;
            }
            Console.WriteLine($"Total acumulado: {total}");
        }

        static void EjemploAnteriorSinBreak()
        {
            int total = 0;
            bool continuar = true;
            for (int i = 0; i < 5 && continuar; i++)
            {
                Console.Write($"Dime un número del 1 al 10 (total {total}): ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 10)
                {
                    total += num;
                }
                else
                {
                    continuar = false;  // Marcamos que no queremos continuar
                    Console.WriteLine("Número no válido");
                }
            }
            Console.WriteLine($"Total acumulado: {total}");
        }


        static void EjemploContinue()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 > 0)
                {
                    continue;
                }
                Console.WriteLine($"Repetición número {i}");
            }
        }
        static void EjemploAnteriorSinContinue()
        {
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine($"Repetición número {i}");
            }
        }

        // Ejemplos de bucles infinitos

        static void EjemploBucleInfinito1()
        {
            for (int i = 2147483640; i >= 0; i++)
            {
                Console.WriteLine($"Bucle infinito con for. Valor de i: {i}");
            }

            int maximo = Int32.MaxValue; // Valor máximo de un entero de 32 bits. 2147483647
            maximo = maximo + 1; // Esto provoca un desbordamiento y vuelve a Int32.MinValue
            Console.WriteLine(maximo);
        }

        static void EjemploBucleInfinito2()
        {
            while (true)
            {
                Console.WriteLine($"Bucle infinito con while.");
            }
        }
        static void EjemploBucleInfinitoConBreak()
        {
            while (true)
            {
                Console.WriteLine("Introduce la contraseña:");
                string contrasena = Console.ReadLine();
                if (contrasena == "1234")
                {
                    Console.WriteLine("Contraseña correcta.");
                    break;
                }
                Console.WriteLine("Contraseña incorrecta.");
            }
        }


        // Bucles anidados. Son bucles dentro de bucles. Se pueden usar con for, while y do-while.

        static void EjemploTablasMultiplicar()
        {
            for (int i = 1; i <= 10; i++)  // Bucle exterior para las tablas del 1 al 10
            {
                Console.WriteLine($"Tabla del {i}:");
                for (int j = 1; j <= 10; j++)  // Bucle interior para multiplicar por 1 al 10
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("-----------------"); // Separador entre tablas
            }
        }

        static void PintarAsteriscosAnchoAlto()
        {
            int alto = 5;
            int ancho = 8;
            for (int fila = 0; fila < alto; fila++)// for exterior
            {
                for (int col = 0; col < ancho; col++) // for interior
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Generamos salto de línea
            }
        }




        static void Main(string[] args)
        {
            //EjemploIf();
            //EjemploIfElse();
            //EjemploIfElseIfElse();
            //EjemploSwitch();
            //EjemploSwitchConString();
            //EjemploSwitchModerno();
            //EjemploTernaria();
            //EjemploTernariaPlurales();
            //EjemploWhile();
            //EjemploDoWhile();
            //EjemploFor();
            //EjemploFor2();
            //EjemploFor3();
            //TablaDel7();
            //ParesDel0Al100();
            //CuentaAtras();
            //BucleForConVariasVariables();
            //EjemploBucleAnteriorConWhile();
            //BucleForComoWhile();
            //ForEach1ConArray();
            //ForEach2ConArrayNombres();
            //EjemploBreak();
            //EjemploAnteriorSinBreak();
            //EjemploContinue();
            //EjemploAnteriorSinContinue();
            //EjemploBucleInfinito1();
            //EjemploBucleInfinito2();
            //EjemploBucleInfinitoConBreak();
            //EjemploTablasMultiplicar();
            PintarAsteriscosAnchoAlto();
        }
    }
}
