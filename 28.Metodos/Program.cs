using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagodia, dias;

            Console.Write("Cuanto te pagan por dia ? ");
            pagodia= int.Parse( Console.ReadLine() );

            Console.Write("Cuantos dias trabajaste ? ");
            dias = int.Parse( Console.ReadLine() );

            Console.WriteLine("Las ganancias por los dias trabajados es de " + resultado(pagodia, dias));
            Console.ReadKey(true);

        }
        //Métodos adicionales
        static int resultado (int xpagodia, int xdias)
        {
            int total;
            total= xpagodia*xdias;
            return total;
        }
    }
}
