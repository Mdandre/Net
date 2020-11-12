using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese mes:");
            string mes = Console.ReadLine();
            int numMes = NumeroMes(mes);
            if (numMes != 0)
            {
                Console.WriteLine(mes + numMes);
            }
            else
            {
                Console.WriteLine("El mes infresado es incorrecto");
            }
            Console.ReadKey();
        }
        static int NumeroMes (string mes)
        {
            switch (mes.ToLower())
            {
                case "enero": return 1;
                case "febrero": return 2;
                case "marzo": return 3;
                case "abril": return 4;
                case "mayo": return 5;
                case "junio": return 6;
                case "juilo": return 7;
                case "agosto": return 8;
                case "septiembre": return 9;
                case "octubre": return 10;
                case "noviembre": return 11;
                case "diciembre": return 12;
                default: return 0;

            }
        }
    }
}
