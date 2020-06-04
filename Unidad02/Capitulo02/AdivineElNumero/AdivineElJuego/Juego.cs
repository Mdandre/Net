using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElJuego
{
    public class Juego
    {
        private int _record;
        private Jugada Jugada;

        public Juego()
        {
            _record = int.MaxValue;
        }

        public void ComenzarJuego(bool conAyuda = false)
        {
            do
            {
                Console.Clear();
                if (conAyuda)
                {
                    
                    Jugada = new JugadaConAyuda(PreguntarMaximo());
                }
                else
                {
                    Jugada = new Jugada(PreguntarMaximo());
                }

                while (!Jugada.Adivino)
                {
                    Jugada.Comparar(PreguntarNumero());
                    if (Jugada.Adivino)
                    {
                        Console.Clear();
                        Console.WriteLine("Numero Correcto!! :D  el numero es =>" + Jugada.Numero);
                        CompararRecord(Jugada.Intentos);
                        Console.ReadKey();
                    }
                }
            } while (Continuar() != ConsoleKey.Escape);
        }

        public void CompararRecord(int intentos)
        {
            if (intentos < _record)
            {
                _record = intentos;
                Console.WriteLine("Nuevo record: " + _record);
            }
        }

        public ConsoleKey Continuar()
        {
            ConsoleKeyInfo rta;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Jugar de nuevo?\nEnter para Continuar\nEscape para Salir");
                rta = Console.ReadKey();
            } while (!(rta.Key == ConsoleKey.Enter || rta.Key == ConsoleKey.Escape));
            return rta.Key;
        }

        public int PreguntarMaximo()
        {
                Console.Write("Ingrese el numero máximo: ");
                return int.Parse(Console.ReadLine());
        }

        public int PreguntarNumero()
        {
            Console.Write("Ingrese numero: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
