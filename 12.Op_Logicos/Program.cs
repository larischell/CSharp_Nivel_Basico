using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Op_Logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 100; b=25; c=45; d=200;
            Console.WriteLine("Consulta Operador AND a<b y c>d ?: "+((a < b) && (c > d)));
            Console.WriteLine("Consulta Operador OR a<b y c>d ?: "+((a < b) || (c > d)));
            Console.WriteLine("Consulta Operador NOT a<b ?: " + (!(a < b)));
            Console.ReadKey(true);
        }
    }
}
