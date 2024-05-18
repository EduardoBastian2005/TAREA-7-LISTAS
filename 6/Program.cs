using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de conjuntos de números
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

        // Llamada a la función y obtención del resultado
        HashSet<int> resultado = DiferenciaInversaConjuntos(conjuntoA, conjuntoB);

        // Impresión de los números que están en el conjunto B pero no en el A
        Console.WriteLine("Números en el conjunto B que no están en el conjunto A:");
        foreach (int numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    // La función que devuelve los números que están en el conjunto B pero no en el A
    static HashSet<int> DiferenciaInversaConjuntos(HashSet<int> conjuntoA, HashSet<int> conjuntoB)
    {
        HashSet<int> resultado = new HashSet<int>(conjuntoB);
        resultado.ExceptWith(conjuntoA);
        return resultado;
    }
}
