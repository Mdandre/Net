using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros pares entre 1-100 son:");
            for (int i = 1; i < 101; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i + " , ");
                }
            }
            Console.ReadKey();
        }
    }
}
