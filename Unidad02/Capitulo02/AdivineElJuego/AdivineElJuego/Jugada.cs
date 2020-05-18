using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivineElJuego
{
    public class Jugada
    {
        private string _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public string Adivino
        {
            get => default;
            set
            {
            }
        }

        public int Intentos
        {
            get => default;
            set
            {
            }
        }

        public int Numero
        {
            get => default;
            set
            {
            }
        }

        public void Comparar()
        {
            throw new System.NotImplementedException();
        }
    }
}