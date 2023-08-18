using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Condicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write("Cual es tu Edad ? ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18){
                Console.WriteLine("Ya sos Mayor de Edad");
            }
            else{
                Console.WriteLine("Todavía sos Menor de Edad");
            }
            Console.ReadKey(true);
        }
    }
}
