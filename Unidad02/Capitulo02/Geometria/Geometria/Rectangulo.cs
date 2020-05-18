using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo:Poligono
    {
        public int LadoA
        {
            get => default;
            set
            {
            }
        }

        public int LadoB
        {
            get => default;
            set
            {
            }
        }
        public int CalcularPerimetro(int L, int M)
        {
            perimetro = L* 2 + M *2;
            return perimetro;
        }

        public int CalcularSuperficie(int Base, int Altura)
        {
            superficie = (Base * Altura);
            return superficie;
        }
    }
}