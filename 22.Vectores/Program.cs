using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sueldo = {900, 1000, 1500, 1800, 2000, 3500 };

            for (int x = 0; x < sueldo.Length; x++)
            {

                Console.WriteLine("El Sueldo es de: " + sueldo[x]);
            }

            Console.ReadKey(true);
        }
    }
}
