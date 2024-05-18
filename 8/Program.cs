using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string> { "anilina", "reconocer", "casa", "oso", "radar" };
        HashSet<string> palindromos = EncontrarPalindromos(palabras);

        Console.WriteLine("Palíndromos encontrados:");
        foreach (string palindromo in palindromos)
        {
            Console.WriteLine(palindromo);
        }
    }

    static HashSet<string> EncontrarPalindromos(HashSet<string> palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }
        return palindromos;
    }

    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;
        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
