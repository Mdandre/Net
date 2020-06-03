using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año");
            int anio = int.Parse(Console.ReadLine());
            if ((anio % 4) == 0)
            {
                if ((anio % 100) == 0)
                {
                    if ((anio % 400) == 0)
                    {
                        Console.WriteLine("Es bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto.");
                    }
                }
                else
                {
                    Console.WriteLine("Es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("No es bisiesto.");
            }
            Console.ReadKey();
        }
    }
}
