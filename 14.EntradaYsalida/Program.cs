using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EntradaYsalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int edad;

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu Nombre es: " + Nombre);
            Console.Write("Edad: ");
            edad=int.Parse(Console.ReadLine());

            Console.WriteLine("Tu edad "+Nombre+" es "+edad+" años");
            Console.ReadKey(true);
        }
    }
}
