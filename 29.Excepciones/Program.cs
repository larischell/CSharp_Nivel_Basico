using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            try
            {
                Console.Write("Cual es tu Edad ? ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Tu año dee Nacimiento es: " + (2023 - edad));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey(true);
        }
    }
}
