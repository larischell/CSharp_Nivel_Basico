using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.EntradaYsalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu Nombre es: " + Nombre);
            Console.ReadKey(true);
        }
    }
}
