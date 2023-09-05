using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombres, apellidos;int edad;

            try
            {
                Console.Write("Ingresa tu Nombre: ");
                nombres = Console.ReadLine();

                Console.Write("Ingresa tu Apellido: ");
                apellidos = Console.ReadLine();

                Console.Write("Ingresa tu Edad: ");
                edad= int.Parse(Console.ReadLine());

                Console.WriteLine("Tus Nombres y Apellidos son: "+nombres+ " " +apellidos);
                Console.WriteLine("Tu Edad es: "+edad+ " Años");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}
