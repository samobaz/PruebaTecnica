using System;
using System.Collections.Generic;

public class numerosDuplicados // Clase con la función para encontrar el primer índice duplicado en un array de números
{
    public static int PrimerIndiceDuplicado(int[] numeros) // Función que recibe un array de números y retorna el primer índice duplicado
    {
        HashSet<int> vistos = new HashSet<int>(); // HashSet para almacenar los números que ya hemos visto

        for (int i = 0; i < numeros.Length; i++) // Iteramos sobre el array de números
        {
            if (vistos.Contains(numeros[i])) // Si el número ya ha sido visto, retornamos el índice
            {
                return i;
            }
            else // Si no, lo añadimos al HashSet
            {
                vistos.Add(numeros[i]);
            }
        }

        return -1; // Si no hay números duplicados, retornamos -1
    }

    public static void Main() // Método Main para probar la función
    {
        int[] entrada1 = { 2, 3, 1, 5, 3, 2 };
        int[] entrada2 = { 1, 2, 3, 4 };

        Console.WriteLine(PrimerIndiceDuplicado(entrada1)); // Output: 4
        Console.WriteLine(PrimerIndiceDuplicado(entrada2)); // Output: -1
    }
}

//Para ejecutar la función, simplemente llamamos al método Main de la clase númerosDuplicados.
//Recomiendo usar un IDE como Visual Studio o Rider para ejecutar el código mediante las funciones de depuración.
