using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string> { "casa", "coche", "sol", "cielo", "mar" };
        int longitudDeseada = 4;
        HashSet<string> palabrasFiltradas = FiltrarPorLongitud(palabras, longitudDeseada);

        Console.WriteLine($"Palabras con longitud de {longitudDeseada} caracteres:");
        foreach (string palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLongitud(HashSet<string> palabras, int longitudDeseada)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitudDeseada)
            {
                palabrasFiltradas.Add(palabra);
            }
        }
        return palabrasFiltradas;
    }
}
