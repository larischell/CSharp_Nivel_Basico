using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            const string documento_identidad= "33.126.469";
            double sueldo;

            nombre = "Juan Ariel";
            sueldo = 2500;

            Console.WriteLine("Mi Nombre es: " + nombre);
            Console.WriteLine("Mi Documento de Identidad es: " + documento_identidad);
            Console.WriteLine("Mi Sueldo es de: " + sueldo);

            Console.ReadKey(true);
        }
    }
}
