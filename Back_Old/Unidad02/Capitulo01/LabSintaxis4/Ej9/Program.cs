using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de filas");
            int filas = int.Parse(Console.ReadLine());
            for (int i = 0; i <= filas; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - 2 * i - 1) / 2, Console.CursorTop);
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
