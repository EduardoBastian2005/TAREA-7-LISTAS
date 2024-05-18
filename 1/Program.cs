using System;
using System.Collections.Generic;

namespace PrimosEnConjunto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los números separados por espacios:");
            var entradas = Console.ReadLine().Split(' ');
            var numeros = new HashSet<int>();

            foreach (var entrada in entradas)
            {
                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine($"La entrada '{entrada}' no es un número válido.");
                }
            }

            var primos = Primos.EncontrarPrimos(numeros);

            if (primos.Count > 0)
            {
                Console.WriteLine("Números primos encontrados:");
                foreach (int primo in primos)
                {
                    Console.WriteLine(primo);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron números primos.");
            }
        }
    }

    public class Primos
    {
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
}
