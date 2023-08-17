using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Datos_Primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte nEdad; int nSueldo;
            double nPeso, nAltura;

            nEdad = 35;

            nSueldo = 2500;

            nPeso = 99.00;
            nAltura = 1.73;

            Console.WriteLine("Edad: " + nEdad);
            Console.WriteLine("Mi Sueldo: " + nSueldo);

            Console.WriteLine("Mi Peso es de: " + nPeso);
            Console.WriteLine("Mi Altura es de: " + nAltura);
            Console.ReadKey(true);
        }
    }
}
