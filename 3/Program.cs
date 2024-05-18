using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Ingrese el número por el cual desea filtrar:");
        int divisor = Convert.ToInt32(Console.ReadLine());

        HashSet<int> divisibles = FiltrarDivisiblesPor(numeros, divisor);

        Console.WriteLine($"Números divisibles por {divisor}:");
        foreach (int numero in divisibles)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> FiltrarDivisiblesPor(HashSet<int> numeros, int divisor)
    {
        HashSet<int> divisibles = new HashSet<int>();
        foreach (int numero in numeros)
        {
            if (divisor != 0 && numero % divisor == 0)
            {
                divisibles.Add(numero);
            }
        }
        return divisibles;
    }
}

