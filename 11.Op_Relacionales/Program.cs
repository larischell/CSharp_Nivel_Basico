using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Op_Relacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool operacion;
            a = 15; b=35; c=35;
            operacion = a < b;

            Console.WriteLine("El Valor de A es Mayor que B? "+(a>b));
            Console.WriteLine("El Valor de A es Menor que B? " + operacion);
            Console.WriteLine("El Valor de B no es Igual a C? "+(b!=c));

            Console.ReadKey(true);
        }
    }
}
