using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivineElJuego
{
    public class JugadaConAyuda: Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }
        public override void Comparar(int numeroPropuesto)
        {
            base.Comparar(numeroPropuesto);
            int dif = Numero - numeroPropuesto;
            if (dif > 100)
            {
                Console.WriteLine("El número es mayor y está muy lejos.");
            }
            else if (dif > 5)
            {
                Console.WriteLine("El número es mayor y está cerca.");
            }
            else if (dif < -100)
            {
                Console.WriteLine("El número es menor y está muy lejos.");
            }
            else if (dif < -5)
            {
                Console.WriteLine("El número es menor y está cerca.");
            }
        }
    }
}