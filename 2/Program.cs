using System.Collections.Generic;

public static HashSet<string> FiltrarPalabrasPorLetra(HashSet<string> palabras, char letra)
{
    HashSet<string> resultado = new HashSet<string>();
    foreach (string palabra in palabras)
    {
        if (!string.IsNullOrEmpty(palabra) && palabra[0] == letra)
        {
            resultado.Add(palabra);
        }
    }
    return resultado;
}
