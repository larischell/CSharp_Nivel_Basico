using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Condicional_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 0;
            while (numero <= 10) {
                Console.WriteLine("El numero es igual a: " + numero);
                numero++;
            }
            Console.ReadKey(true);
        }
    }
}
