using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    /*Ejercicio1
    class Program
    {
        static void Main(string[] args)
        {
            string[] Provincias = { "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" };
            IEnumerable<string> lst = from c in Provincias
                       where c.StartsWith("S") || c.StartsWith("T")
                                      select c;

            foreach (var a in lst)
            {
                Console.WriteLine(a);
            }

        }
    }*/
    /*Ejercicio2*/
   class Program
   {
       static void Main(string[] args)
       {
            /*Lista <string> listaInt = new Lista<string>();*/
            ArrayList Listado = new ArrayList();
            string rta = "S";
            while (rta != "N")
            {
                Console.WriteLine("Igrese numero:");
                Listado.Add(Console.ReadLine());
            }
           foreach (var a in Listado)
           {
               if (a >= 20)
                {
                    Console.WriteLine(a);
                }
                
           }

       }
   }
}
