using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string[] palabras = new String[5];
           for(int cantIteraciones = 0; cantIteraciones < 5; cantIteraciones++)
            {
                System.Console.WriteLine("Ingrese una palabra");
                palabras[cantIteraciones] = Console.ReadLine();
            }
            for(int cantIteraciones = 4; cantIteraciones >= 0; cantIteraciones --)
            {
                Console.WriteLine("Palabra posicion  " + cantIteraciones + "\r\n" + palabras[cantIteraciones]);
            }
            Console.ReadKey();
        }
    }
}
