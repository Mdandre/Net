using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de " + num1 + "  y  " + num2 + "  es: " + (num1 + num2));
            Console.ReadLine();
        }
    }
}
