using System;
using System.Collections.Generic;

public class Primos
{
    // Cambio del nombre del método a PascalCase
    public static HashSet<int> EncontrarPrimos(HashSet<int> numeros)
    {
        HashSet<int> primos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
            {
                primos.Add(numero);
            }
        }

        return primos;
    }

    // Método auxiliar para verificar si un número es primo
    private static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        var limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }
}

// Uso de la función con el nombre del método actualizado
var numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var primos = Primos.EncontrarPrimos(numeros);

foreach (int primo in primos)
{
    Console.WriteLine(primo);
}
