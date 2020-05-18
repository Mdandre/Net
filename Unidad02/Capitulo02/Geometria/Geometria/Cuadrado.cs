using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado:Poligono
    {
        public int Lado
        {
            get => default;
            set
            {
            }
        }
        public int CalcularPerimetro(int L)
        {
            perimetro = L * 4;
            return perimetro;
        }

        public int CalcularSuperficie(int L)
        {
            superficie = L*L;
            return superficie;
        }
    }
}