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


        static void Main(string[] args)
        {
            //DeclaracionArrays();
            //RecorrerArraysFor();
            //RecorrerArraysForEach();
            //BuscarElementosArrays();
            //BuscarElementosArrays2();
        }
    }
}
