using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        string _NombreInstancia;
        public string NombreInstancia 
        {
          get
          {
            return _NombreInstancia;
          }
          set
          {
            _NombreInstancia = value;
          }
        }
        public A() 
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            NombreInstancia = nombre;
        }
        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("El nombre del metodo es M1");
        }
        public void M2()
        {
            Console.WriteLine("El nombre del metodo es M2");
        }
        public void M3()
        {
            Console.WriteLine("El nombre del metodo es M3");
        }
    }
    
}
