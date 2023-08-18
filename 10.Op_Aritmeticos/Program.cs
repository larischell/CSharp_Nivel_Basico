using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Op_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;

            valor1 = 10;
            valor2 = 3;

            Console.WriteLine("La Suma de " + valor1 + " + " + valor2 + " es: " + (valor1 + valor2));
            Console.WriteLine("La Resta de " + valor1 + " - " + valor2 + " es: " + (valor1 - valor2));
            Console.WriteLine("La Multiplicación de " + valor1 + " * " + valor2 + " es: " + (valor1 * valor2));
            Console.WriteLine("La División de " + valor1 + " / " + valor2 + " es: " + (valor1 / valor2));
            Console.WriteLine("El Residuo de la División " + valor1 + " % " + valor2 + " es: " + (valor1 % valor2));
            Console.ReadKey(true);
        }
    }
}
