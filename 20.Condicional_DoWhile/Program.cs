using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Condicional_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 100;

            do {
                Console.WriteLine("el valor del número es: "+numero);
                numero++; 
            } while (numero < 99);

            Console.ReadKey(true);  
        }
    }
}
