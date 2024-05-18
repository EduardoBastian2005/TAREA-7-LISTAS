using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string> { "casa", "coche", "sol", "cielo", "mar" };
        char letraDeseada = 'a'; // Puedes cambiar esto por la letra que desees buscar
        HashSet<string> palabrasConLetra = FiltrarPalabrasPorLetra(palabras, letraDeseada);

        Console.WriteLine($"Palabras que contienen la letra '{letraDeseada}':");
        foreach (string palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLetra(HashSet<string> palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }
        return palabrasConLetra;
    }
}
