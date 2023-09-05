using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            datos();

            Console.ReadKey(true);
        }
        static void datos() {
            string nombres, apellidos;
            Console.Write("Ingrese un Nombre: ");
            nombres = Console.ReadLine();

            Console.Write("Ingreese un Apellido: ");
            apellidos = Console.ReadLine();

            Console.WriteLine("Tu Nombre y tu Apellido es: "+nombres+" "+apellidos);
        }
    }
}
