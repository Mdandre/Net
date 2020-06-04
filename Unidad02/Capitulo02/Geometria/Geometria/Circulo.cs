using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Geometria
{
    public class Circulo
    {
        private double m_radio;
        
        public double Radio
        {
            get
            {
                return m_radio;
            }
            set
            {
                m_radio = value;
            }
        }
        public Circulo(int radio)
        {
            Radio = radio;
        }

        public double CalcuarPerimetro()
        {
            return 2 * Math.PI * m_radio;
        }

        public double CalcularSuperficie()
        {
            return Math.PI*Math.Pow(m_radio,2);
        }
    }
}
