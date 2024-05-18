using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso de la función DiferenciaConjuntos
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> resultado = DiferenciaConjuntos(conjuntoA, conjuntoB);

        Console.WriteLine("Elementos en el conjunto A que no están en el conjunto B:");
        foreach (int numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> DiferenciaConjuntos(HashSet<int> conjuntoA, HashSet<int> conjuntoB)
    {
        HashSet<int> resultado = new HashSet<int>(conjuntoA);
        resultado.ExceptWith(conjuntoB);
        return resultado;
    }
}
