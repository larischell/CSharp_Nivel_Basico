using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz_datos = new string[3, 2];
            matriz_datos[0,0] = "Juan";
            matriz_datos[0,1] = "Ariel";
            matriz_datos[1,0] = "Schell";

            Console.WriteLine(matriz_datos[0,0]+" , " + matriz_datos[0,1]);
            Console.WriteLine(matriz_datos[1,0]);



            Console.ReadKey(true);
        }
    }
}
