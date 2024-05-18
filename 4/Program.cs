using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso de la función InterseccionConjuntos
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6, 7 };

        HashSet<int> resultado = InterseccionConjuntos(conjuntoA, conjuntoB);

        Console.WriteLine("Elementos comunes en ambos conjuntos:");
        foreach (int numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> InterseccionConjuntos(HashSet<int> conjuntoA, HashSet<int> conjuntoB)
    {
        HashSet<int> resultado = new HashSet<int>(conjuntoA);
        resultado.IntersectWith(conjuntoB);
        return resultado;
    }
}
