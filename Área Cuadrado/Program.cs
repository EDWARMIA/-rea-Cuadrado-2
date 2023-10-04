using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Calculadora de área de cuadrado");

                Console.Write("Ingrese la longitud de un lado del cuadrado: ");
                double lado = double.Parse(Console.ReadLine());

                double area = lado * lado;

                Console.WriteLine($"El área del cuadrado con lado {lado} es: {area}");

                Console.ReadLine();
            }
        }
    }
}

