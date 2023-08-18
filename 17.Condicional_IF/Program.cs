using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Condicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write("Cual es tu Edad ? ");
            edad= int.Parse(Console.ReadLine());

            if( edad <= 10 ) {
                Console.WriteLine("Eres un niño");
            }else if( edad <= 17 ){
                Console.WriteLine("Eres un Joven");
            }else if (edad <= 65){
                Console.WriteLine("Eres un Adulto");
            }
            else{
                Console.WriteLine("Eres un Adulto Mayor");
            }
                Console.ReadKey();
        }
    }
}
