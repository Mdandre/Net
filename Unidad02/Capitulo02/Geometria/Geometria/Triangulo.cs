using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private double _Altura;
        private double _Base;
        private double _L;
        private double _M;
        private double _N;

        public double Base { get; set; }
        public double Altura { get; set; }
        public double M { get; set; }
        public double N { get; set; }
        public double L { get; set; }
        public Triangulo(double m, double n, double l, double basex, double altura)
        {
            Base = basex;
            Altura = altura;
            M = m;
            N = n;
            L = l;
        }
        public double    CalcularPerimetro()
        {
            return M + N + L;
        }

        public double CalcularSuperficie( )
        {
            return (Base + Altura) / 2;
        }
    }
}