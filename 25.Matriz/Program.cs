using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas;

            Console.Write("Indicar la Cantidad de Filas de la Matriz: ");
            filas= int.Parse(Console.ReadLine());

            Console.Write("Indicar la Cantidad de Columnas de la Matriz: ");
            columnas = int.Parse(Console.ReadLine());

            string[,] matriz_datos = new string[filas,columnas];

            Console.WriteLine("Mantenimineto de Datos para la Matriz ... ");
            for (int x=0;x<filas;x++){
                for (int y=0; y<columnas; y++) {
                    Console.Write("Ingresar datos para la Matriz ["+x+", "+y+"] : ");
                    matriz_datos[x, y] = Console.ReadLine();
                }
            }
            Console.ReadKey(true);
        }
    }
}
