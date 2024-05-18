using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string> { "casa", "coche", "sol", "cielo", "mar" };
        char letraInicial = 'c'; // Puedes cambiar esto por la letra inicial que desees buscar
        HashSet<string> palabrasConLetra = FiltrarPalabrasPorLetraInicial(palabras, letraInicial);

        Console.WriteLine($"Palabras que comienzan con la letra '{letraInicial}':");
        foreach (string palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLetraInicial(HashSet<string> palabras, char letraInicial)
    {
        HashSet<string> palabrasConLetraInicial = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (!string.IsNullOrEmpty(palabra) && palabra[0] == letraInicial)
            {
                palabrasConLetraInicial.Add(palabra);
            }
        }
        return palabrasConLetraInicial;
    }
}

