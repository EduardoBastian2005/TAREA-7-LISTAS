//11.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor. 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números con espacios: ");//Declaración de variables
//        string entrada = Console.ReadLine();

//        string[] numerosTexto = entrada.Split(' ');
//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();

//        Array.Sort(numeros);//Ordena los elementos

//        Console.WriteLine("Números ordenados de menor a mayor:");
//        foreach (var numero in numeros)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}


//12.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de mayor a menor. 
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");//Declarar variables
//        string entrada = Console.ReadLine();

//        string[] numerosTexto = entrada.Split(' ');

//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();//convertir en número entero

//        // Ordenar los números de mayor a menor
//        Array.Sort(numeros);
//        Array.Reverse(numeros);

//        Console.WriteLine("Números ordenados de mayor a menor:");
//        foreach (var numero in numeros)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}

//13.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están duplicados.


//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> conjuntoNumeros = new List<int>();
//        Console.WriteLine("Ingrese números separados por espacios:");
//        conjuntoNumeros.AddRange(Console.ReadLine().Split(' ').Select(int.Parse));

//        HashSet<int> resultado = EncontrarDuplicados(conjuntoNumeros);
//        Console.WriteLine("Números duplicados:");
//        foreach (var numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    static HashSet<int> EncontrarDuplicados(List<int> numeros)
//    {
//        return new HashSet<int>(numeros.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key));
//    }
//}


//14.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que no están duplicados. 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> conjuntoNumeros = new List<int>();
//        Console.WriteLine("Ingrese números separados por espacios:");
//        conjuntoNumeros.AddRange(Console.ReadLine().Split(' ').Select(int.Parse));

//        HashSet<int> resultado = EncontrarNoDuplicados(conjuntoNumeros);
//        Console.WriteLine("Números no duplicados:");
//        foreach (var numero in resultado)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    static HashSet<int> EncontrarNoDuplicados(List<int> numeros)
//    {
//        return new HashSet<int>(numeros.GroupBy(n => n).Where(g => g.Count() == 1).Select(g => g.Key));
//    }
//}

//15.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son primos y están ordenados de menor a mayor.
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static bool EsPrimo(int numero)
//    {
//        if (numero <= 1) return false;
//        for (int i = 2; i * i <= numero; i++)
//        {
//            if (numero % i == 0) return false;
//        }
//        return true;
//    }

//    static List<int> NumerosPrimosEnRango(int desde, int hasta)
//    {
//        List<int> listaPrimos = new List<int>();

//        if (desde < 2) desde = 2; // Aseguramos que desde sea >= 2

//        for (int entero = desde; entero <= hasta; entero++)
//        {
//            if (EsPrimo(entero))
//            {
//                listaPrimos.Add(entero);
//            }
//        }

//        return listaPrimos;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa el valor inicial del rango: ");
//        int desde = int.Parse(Console.ReadLine());

//        Console.Write("Ingresa el valor final del rango: ");
//        int hasta = int.Parse(Console.ReadLine());

//        List<int> primosEnRango = NumerosPrimosEnRango(desde, hasta);

//        Console.WriteLine("Números primos en el rango [{0}, {1}]:", desde, hasta);
//        foreach (var primo in primosEnRango)
//        {
//            Console.Write(primo + " ");
//        }
//    }
//}

//16.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos y están ordenadas de menor a mayor. 

//using System;
//using System.Linq;

//class Program
//{
//    static bool EsPalindromo(string palabra)
//    {
//        palabra = palabra.ToLower(); // Convertimos a minúsculas para ser insensibles a mayúsculas
//        int izquierda = 0;
//        int derecha = palabra.Length - 1;

//        while (izquierda < derecha)
//        {
//            if (palabra[izquierda] != palabra[derecha])
//                return false;

//            izquierda++;
//            derecha--;
//        }

//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        Filtrar las palabras palíndromas
//        var palindromos = palabras.Where(EsPalindromo).OrderBy(p => p);

//        Console.WriteLine("Palabras palíndromas ordenadas de menor a mayor:");
//        foreach (var palindromo in palindromos)
//        {
//            Console.WriteLine(palindromo);
//        }
//    }
//}

//17.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que tienen una longitud determinada y están ordenadas de menor a mayor. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la longitud deseada para las palabras: ");
//        int longitudDeseada = int.Parse(Console.ReadLine());

//        // Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        // Filtrar las palabras por longitud
//        var palabrasFiltradas = palabras.Where(palabra => palabra.Length == longitudDeseada)
//                                        .OrderBy(palabra => palabra);

//        Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas de menor a mayor:");
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}

//18.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que contienen una letra determinada y están ordenadas de mayor a menor. 
//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa las palabras separadas por espacios: ");
//        string entrada = Console.ReadLine();

//        Console.Write("Ingresa la letra a buscar: ");
//        char letra = Console.ReadKey().KeyChar;
//        Console.WriteLine(); // Salto de línea

//        Dividir la entrada en palabras
//        string[] palabras = entrada.Split(' ');

//        Filtrar las palabras que contienen la letra especificada
//        var palabrasFiltradas = palabras.Where(palabra => palabra.Contains(letra))
//                                        .OrderByDescending(palabra => palabra);

//        Console.WriteLine($"Palabras que contienen la letra '{letra}' ordenadas de mayor a menor:");
//        foreach (var palabra in palabrasFiltradas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//}

//19.	Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que están ordenados de menor a mayor y que no están duplicados. 
using System;
using System.Linq;
using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ingresa los números separados por espacios: ");
//        string entrada = Console.ReadLine();

//        // Dividir la entrada en números
//        string[] numerosTexto = entrada.Split(' ');

//        // Convertir los números a enteros
//        int[] numeros = numerosTexto.Select(int.Parse).ToArray();

//        // Ordenar los números de menor a mayor
//        Array.Sort(numeros);

//        // Eliminar duplicados
//        List<int> numerosSinDuplicados = numeros.Distinct().ToList();

//        Console.WriteLine("Números ordenados de menor a mayor (sin duplicados):");
//        foreach (var numero in numerosSinDuplicados)
//        {
//            Console.Write(numero + " ");
//        }
//    }
//}

//20.	Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor. 
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        palabra = palabra.ToLower(); // Convertimos a minúsculas para ser insensibles a mayúsculas
        int izquierda = 0;
        int derecha = palabra.Length - 1;

        while (izquierda < derecha)
        {
            if (palabra[izquierda] != palabra[derecha])
                return false;

            izquierda++;
            derecha--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Ingresa las palabras separadas por espacios: ");
        string entrada = Console.ReadLine();

        Console.Write("Ingresa la longitud deseada para las palabras: ");
        int longitudDeseada = int.Parse(Console.ReadLine());

        string[] palabras = entrada.Split(' ');

        var palindromosFiltrados = palabras.Where(palabra => EsPalindromo(palabra) && palabra.Length == longitudDeseada)        // Filtrar las palabras que son palíndromos y de la misma lomgitud

                                           .OrderBy(palabra => palabra);

        Console.WriteLine($"Palíndromos de longitud {longitudDeseada} ordenados de menor a mayor:");
        foreach (var palindromo in palindromosFiltrados)
        {
            Console.WriteLine(palindromo);
        }
    }
}

