using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Variable_Dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte nEdad = 35;
            int nSueldo = 2500;
            double nPeso, nAltura;

            string cNombres, cApellidos;
            bool lEstudia;

            dynamic variable_dinamica;
            variable_dinamica = 2500.67;

            cNombres = "Juan Ariel";
            cApellidos = "Schell";

            nPeso = 99.80;
            nAltura = 1.73;

            lEstudia = true;

            Console.WriteLine("Mi Nombre es: " + cNombres);
            Console.WriteLine("Mi Apellido es: " + cApellidos);

            Console.WriteLine("Edad: " + nEdad + " años");
            Console.WriteLine("Mi Sueldo es de: " + nSueldo + " Pesos");

            Console.WriteLine("Mi Peso es de: " + nPeso + " Kg.");
            Console.WriteLine("Mi Altura es de: " + nAltura + " Mts.");

            Console.WriteLine("Estudias? " + lEstudia);
            
            // La Variable dinamica puede recibir cualquieer tipo de dato (bool, string,etc).
            Console.WriteLine("Variable Dinamica " + variable_dinamica);

            Console.ReadKey(true);
        }
    }
}
