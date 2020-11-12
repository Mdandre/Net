using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivineElJuego
{
    class Program
    {
        static void Main(string[] arg)
        {
            ConsoleKeyInfo rta;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Qué tipo de juego vas a jugar?\n 1 - Sin ayuda \n 2 - Con ayuda\n 3 - Salir");
                rta = Console.ReadKey();
            } while (!(rta.Key == ConsoleKey.D1 || rta.Key == ConsoleKey.D2 || rta.Key == ConsoleKey.D3));
            Console.Clear();
            Juego juego = new Juego();
            switch (rta.Key)
            {
                case ConsoleKey.D1:
                    juego.ComenzarJuego();
                    break;
                case ConsoleKey.D2:
                    juego.ComenzarJuego(true);
                    break;
                default:
                    Console.WriteLine("FIN...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}