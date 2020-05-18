using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Double;

namespace Geometria
{
    public class Circulo
    {
        private double m_radio;
        private double _perimetro;
        private double _superficie;

        public double Radio
        {
            get => default;
            set
            {
            }
        }

        public double perimetro
        {
            get => default;
            set
            {
            }
        }

        public double superficie
        {
            get => default;
            set
            {
            }
        }

        public double CalcuarPerimetro(double R)
        {
            perimetro = 2 * 3.1415 * R;
            return perimetro;
        }

        public double CalcularSuperficie(double R)
        {
            superficie= 3.1416*R*R;
            return superficie;
        }
    }
}
