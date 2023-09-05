using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombres, apellidos;
            Console.Write("Ingrese un Nombre: ");
            nombres = Console.ReadLine();

            Console.Write("Ingreese un Apellido: ");
            apellidos = Console.ReadLine();

            datos(nombres, apellidos);

            Console.ReadKey(true);
        }
        //Desde este punto vamos a crear metodos 
        static void datos(string xnombres, string xapellidos)
        {
            Console.WriteLine("Tu Nombre y tu Apellido es: " + xnombres + " " + xapellidos);
        }
    }
}
