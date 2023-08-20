using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;

            Console.Write("Indicar el Dia de la semana en número: ");
            dia= int.Parse(Console.ReadLine());
            
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default: Console.WriteLine("Dia de semana inexistente");
                    break;
            }
            Console.ReadKey();
        }
    }
}
