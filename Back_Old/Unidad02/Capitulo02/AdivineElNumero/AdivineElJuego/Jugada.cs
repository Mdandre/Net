using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivineElJuego
{
    public class Jugada
    {
        private bool _adivino = false ;
        private int _intentos = 0;
        private int _numero;
        public bool Adivino { get => _adivino; set => _adivino = value; }
        public int Intentos { get => _intentos; set => _intentos = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }
        public virtual void Comparar(int numeroJugado)
        {
            Intentos++;
            Adivino = (numeroJugado == Numero);
        }
    }
}