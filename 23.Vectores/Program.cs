using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            Console.Write("Indicar N cantidad de Sueldos a Ingresar: ");
            cantidad=int.Parse(Console.ReadLine());

            double [] sueldos= new double[cantidad];
            
            for (int x = 0; x<cantidad; x++) {
                Console.Write("Ingrese el Sueldo N: " +x+ " : ");
                sueldos[x]=double.Parse(Console.ReadLine());    
            }
            for (int y = 0; y<cantidad; y++)
            {
                Console.WriteLine("El Sueldo N "+y+" : " + sueldos[y]);
            }
            Console.ReadKey(true);
        }
    }
}
