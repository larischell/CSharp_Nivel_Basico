using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.EntradaYsalida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int edad;
            byte peso;

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu Nombre es: " + Nombre);
            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu edad " + Nombre + " es " + edad + " años");

            Console.Write("Peso: ");
            peso = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Tu Peso " + Nombre + " es " + peso + " kg. ");
            Console.ReadKey(true);
        }
    }
}
