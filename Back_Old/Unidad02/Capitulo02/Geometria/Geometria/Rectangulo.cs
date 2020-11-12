using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public Rectangulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public override double CalcularPerimetro()
        {
            return 2*(LadoA+LadoB);
        }

        public override double CalcularSuperficie()
        {
            return LadoA* LadoB;
        }
    }
}