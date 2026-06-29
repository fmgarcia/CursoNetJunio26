namespace Arrays
{
    internal class Program
    {

        static void DeclaracionArrays()
        {
            int[] numeros = new int[5];  // Declaración de un array de enteros con 5 elementos
            // Asignación de valores a los elementos del array
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;
            //numeros[5] = 6; // Esto generará un error de índice fuera de rango
            int[] numeros2 = { 12, 23, 53, 5, 92 };  // Declaración e inicialización de un array de enteros con valores específicos
        }

        static void RecorrerArraysFor()
        {
            int[] numeros = { 12, 23, 53, 5, 92 };  // Declaración e inicialización de un array de enteros con valores específicos
            for (int i = 0; i < numeros.Length; i++)  // Bucle for para recorrer el array
            {
                Console.WriteLine($"Elemento {i}: {numeros[i]}");  // Imprime cada elemento del array
            }
        }

        static void RecorrerArraysForEach()
        {
            int[] numeros = { 12, 23, 53, 5, 92 };  // Declaración e inicialización de un array de enteros con valores específicos
            foreach (int numero in numeros)  // Bucle foreach para recorrer el array
            {
                Console.WriteLine($"Elemento: {numero * 2}");  // Imprime cada elemento del array multiplicado por 2
            }
        }

        static void BuscarElementosArrays()
        {
            string[] nombres = { "Juan", "Ana", "Pedro", "Eva", "Paco" };
            bool encontrado = false; // Nos indicará si hemos encontrado el valor
            string buscar = "Pedro"; // Valor a buscar en el array
                                     // La condición también incluye que no hayamos encontrado lo que buscamos
            for (int i = 0; i < nombres.Length && !encontrado; i++)
            {
                if (nombres[i] == buscar)
                {
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                Console.WriteLine($"El nombre {buscar} está en el array");
            }
            else
            {
                Console.WriteLine($"{buscar} no encontrado...");
            }
        }
        static void BuscarElementosArrays2()
        {
            string[] nombres = { "Juan", "Ana", "Pedro", "Eva", "Paco" };
            bool encontrado = false; // Nos indicará si hemos encontrado el valor
            string buscar = "Pedro"; // Valor a buscar en el array
                                     // La condición también incluye que no hayamos encontrado lo que buscamos
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == buscar)
                {
                    encontrado = true;
                    break; // Salimos del bucle si encontramos el valor
                }
            }
            if (encontrado)
            {
                Console.WriteLine($"El nombre {buscar} está en el array");
            }
            else
            {
                Console.WriteLine($"{buscar} no encontrado...");
            }
        }

        static void BuscarElementosArrays3()
        {
            string[] nombres = { "Juan", "Ana", "Pedro", "Eva", "Paco" };
            string buscar = "Pedro"; // Valor a buscar en el array
            bool encontrado = Array.Exists(nombres, nombre => nombre == buscar); // Usamos Array.Exists para buscar el valor
            Console.WriteLine($"{buscar} {(encontrado ? "sí" : "no")} está en el array");
        }

        static void RedimensionarArrays()
        {
            string[] nombres = { "Juan", "Ana", "Pedro", "Eva", "Paco" };
            string[] nombresAux = new string[10];
            for (int i = 0; i < nombres.Length; i++)
            {
                nombresAux[i] = nombres[i];
            }
            nombres = nombresAux; // La variable nombres apunta al array redimensionado
            nombres[5] = "Marta";
        }

        static void RedimensionarArrays2()
        {
            string[] nombres = { "Juan", "Ana", "Pedro", "Eva", "Paco" };
            Array.Resize(ref nombres, 10); // Redimensionamos el array a 10 elementos
            nombres[5] = "Marta"; // Asignamos un valor al nuevo elemento
        }


        static void BorrarElementosArrays()
        {
            const int MAX_ITEMS = 10;
            // MAX_ITEMS = 11;  // Esto generará un error de compilación, ya que MAX_ITEMS es una constante
            int[] nums = new int[MAX_ITEMS];
            int guardados = 0;
            nums[guardados++] = 15;
            nums[guardados++] = 6;
            nums[guardados++] = 9;
            nums[guardados++] = 12;
            nums[guardados++] = 20;
            Console.WriteLine($"Números guardados: {guardados}"); // Números guardados: 5
            for (int i = 0; i < guardados; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 9 12 20

            // Ahora vamos a borrar la posición 2 (número 9)
            for (int i = 2; i < guardados - 1; i++)
            {
                nums[i] = nums[i + 1]; // Desplazamos los números a la izquierda
            }
            guardados--; // Decrementamos el número de elementos guardados

            for (int i = 0; i < guardados; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 12 20 (posición borrada con éxito)
            Console.WriteLine($"Números guardados: {guardados}"); // Números guardados: 4
        }

        static void BorrarElementosArrays2()
        {
            int[] nums = { 15, 6, 9, 12, 20 };
            Console.WriteLine($"Números guardados: {nums.Length}"); // Números guardados: 5
                                                                    // Ahora vamos a borrar la posición 2 (número 9)
            for (int i = 2; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1]; // Desplazamos los números a la izquierda
            }
            Array.Resize(ref nums, nums.Length - 1); // Redimensionamos una posición menos
            Console.WriteLine($"Números guardados: {nums.Length}");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 12 20 (posición borrada con éxito)
        }

        static void BorrarElementosArrays3ConCopy()
        {
            int[] nums = { 15, 6, 9, 12, 20 };
            Console.WriteLine($"Números guardados: {nums.Length}");

            int posicion = Array.IndexOf(nums, 9); // Devuelve la posición del elemento 9 en el array (2)
            // Ahora vamos a borrar la posición 2 (número 9)
            int[] numsAux = new int[nums.Length - 1];  // 0 0 0 0

            Array.Copy(nums, 0, numsAux, 0, posicion);  // 15 6 0 0
            Array.Copy(nums, posicion + 1, numsAux, posicion, nums.Length - posicion - 1);  // 15 6 12 20

            nums = numsAux;
            Console.WriteLine($"Números guardados: {nums.Length}");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 12 20 (posición borrada con éxito)
        }
        static void BorrarElementosArrays3ConCopyCadenas()
        {
            string[] nombres = { "Fran", "María", "Juan", "Ana", "Luis" };
            Console.WriteLine($"Escriba el nombre que desea borrar:");
            string nombreABorrar = Console.ReadLine()!;

            int posicion = Array.IndexOf(nombres, nombreABorrar); // Devuelve la posición del elemento en el array
            // Ahora vamos a borrar la posición encontrada si el nombre existe en el array
            if (posicion != -1)
            {
                string[] nombresAux = new string[nombres.Length - 1];

                Array.Copy(nombres, 0, nombresAux, 0, posicion);
                Array.Copy(nombres, posicion + 1, nombresAux, posicion, nombres.Length - posicion - 1);

                nombres = nombresAux;
            }
            Console.WriteLine($"Nombres guardados: {nombres.Length}");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write(nombres[i] + " ");
            }
            Console.WriteLine(); // 15 6 12 20 (posición borrada con éxito)
        }

        static void InsertarElementoEnUnaPosicionArray()
        {
            const int MAX_ITEMS = 10;
            int[] nums = new int[MAX_ITEMS];
            int guardados = 0;
            nums[guardados++] = 15;
            nums[guardados++] = 6;
            nums[guardados++] = 9;
            nums[guardados++] = 12;
            nums[guardados++] = 20;  // 15 6 9 12 20 0 0 0 0 0
            Console.WriteLine($"Números guardados: {guardados}"); // Números guardados: 5

            // Vamos a insertar el número 2 en la posición 3 (donde está el 12). El objetivo es que el array quede así: 15 6 9 2 12 20 0 0 0 0
            int posicion = 3;
            int numeroAInsertar = 2;
            if (guardados < MAX_ITEMS) // Comprobamos que cabe
            {
                for (int i = guardados - 1; i >= posicion; i--) // Recorremos al revés
                {
                    nums[i + 1] = nums[i]; // Desplazamos los números a la derecha
                } // 15 6 9 12 12 20 0 0 0 0
                nums[posicion] = numeroAInsertar; // Insertamos el número en la posición especificada. 15 6 9 2 12 20 0 0 0 0
                guardados++;
            }
            Console.WriteLine($"Números guardados: {guardados}"); // Números guardados: 6
            for (int i = 0; i < guardados; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 9 2 12 20 (posición insertada con éxito)
        }

        static void InsertarElementoEnUnaPosicionArray2()
        {
            int[] nums = { 15, 6, 9, 12, 20 };
            // Ahora vamos a insertar el número 2 en la posición 3
            Array.Resize(ref nums, nums.Length + 1); // Redimensionamos array
            int posicion = 3;
            int numeroAInsertar = 2;
            for (int i = nums.Length - posicion + 1; i >= posicion; i--)
            {
                nums[i + 1] = nums[i]; // Desplazamos los números a la derecha
            }
            nums[posicion] = numeroAInsertar; // Añadimos el 2 en la posición 3
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 15 6 9 2 12 20 (posición insertada con éxito)
        }


        static void OrdenarArraysBurbuja()
        {
            int[] nums = { 15, 6, 9, 12, 20 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i]) // Intercambiamos
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 6 9 12 15 20 (Ordenados)
        }

        static void OrdenarArrays()
        {
            int[] nums = { 15, 6, 9, 12, 20 };
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); // 6 9 12 15 20 (Ordenados)
        }
        static void OrdenarArraysCadenas()
        {
            string[] cadenas = { "banana", "manzana", "naranja", "uva", "pera", "pero" };
            Array.Sort(cadenas);
            for (int i = 0; i < cadenas.Length; i++)
            {
                Console.Write(cadenas[i] + " ");
            }
            Console.WriteLine(); // banana manzana naranja pera uva (Ordenadas)
        }

        static void Main(string[] args)
        {
            //DeclaracionArrays();
            //RecorrerArraysFor();
            //RecorrerArraysForEach();
            //BuscarElementosArrays();
            //BuscarElementosArrays2();
            //BuscarElementosArrays3();
            //RedimensionarArrays();
            //RedimensionarArrays2();
            //BorrarElementosArrays();
            //BorrarElementosArrays2();
            //BorrarElementosArrays3ConCopy();
            //BorrarElementosArrays3ConCopyCadenas();
            //InsertarElementoEnUnaPosicionArray();
            //InsertarElementoEnUnaPosicionArray2();
            OrdenarArraysBurbuja();
            OrdenarArrays();
            OrdenarArraysCadenas();
        }
    }
}
