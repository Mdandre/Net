using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo:Poligono
    {
        private int _Altura;
        private int _Base;
        private int _L;
        private int _M;
        private int _N;

        public int Base
        {
            get => default;
            set
            {
            }
        }

        public int Altura
        {
            get => default;
            set
            {
            }
        }

        public int M
        {
            get => default;
            set
            {
            }
        }

        public int N
        {
            get => default;
            set
            {
            }
        }

        public int L
        {
            get => default;
            set
            {
            }
        }
        public int CalcularPerimetro(int L, int M, int N)
        {
            perimetro = L + N + M;
            return perimetro;
        }

        public int CalcularSuperficie(int Base, int Altura)
        {
            superficie = (Base * Altura) / 2;
            return superficie;
        }
    }
}