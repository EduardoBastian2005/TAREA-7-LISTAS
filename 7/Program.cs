using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> palabras = new HashSet<string> { "amor", "roma", "mora", "ramo", "pedro", "dormir" };
        var anagramas = EncontrarAnagramas(palabras);

        foreach (var par in anagramas)
        {
            Console.WriteLine($"({par.Item1}, {par.Item2})");
        }
    }

    static HashSet<Tuple<string, string>> EncontrarAnagramas(HashSet<string> palabras)
    {
        HashSet<Tuple<string, string>> paresAnagramas = new HashSet<Tuple<string, string>>();
        var listadoPalabras = palabras.ToList();

        for (int i = 0; i < listadoPalabras.Count; i++)
        {
            for (int j = i + 1; j < listadoPalabras.Count; j++)
            {
                if (SonAnagramas(listadoPalabras[i], listadoPalabras[j]))
                {
                    paresAnagramas.Add(Tuple.Create(listadoPalabras[i], listadoPalabras[j]));
                }
            }
        }

        return paresAnagramas;
    }

    static bool SonAnagramas(string palabra1, string palabra2)
    {
        var arreglo1 = palabra1.ToCharArray();
        var arreglo2 = palabra2.ToCharArray();
        Array.Sort(arreglo1);
        Array.Sort(arreglo2);
        return arreglo1.SequenceEqual(arreglo2);
    }
}

