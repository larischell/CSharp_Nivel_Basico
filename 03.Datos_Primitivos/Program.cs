using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Datos_Primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte nEdad; int nSueldo;

            nEdad = 35;

            nSueldo = 2500;

            Console.WriteLine("Edad: " + nEdad);
            Console.WriteLine("Mi Sueldo: " + nSueldo);
            Console.ReadKey(true);
        }
    }
}
