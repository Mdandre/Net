using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A Aa = new A();
            Aa.M1();
            Aa.M2();
            Aa.M3();
            Aa.MostrarNombre();
            Console.WriteLine(Aa.NombreInstancia);
            B Bb = new B();
            Bb.M4();
            Bb.M1();
            Bb.M2();
            Bb.M3();
            Bb.MostrarNombre();
            Console.WriteLine(Bb.NombreInstancia);
            Console.ReadLine();
        }
    }
}
