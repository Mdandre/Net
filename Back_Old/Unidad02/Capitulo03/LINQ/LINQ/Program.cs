using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

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
    /*Ejercicio2
   class Program
   {
       static void Main(string[] args)
       {           
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
   }*/
    /*Ejercicio2*/
    class Program
    {
        static void Main(string[] args)
        {
            Ciudad[] list =
            {
                new Ciudad (1, "Buenos Aires"),
                new Ciudad (2, "Rosario"),
                new Ciudad (3, "Mar del Plata"),
                new Ciudad (4, "Ushuaia"),
                new Ciudad (5, "Ciudad de Cordoba"),
                new Ciudad (6, "San Carlos de Bariloche"),
                new Ciudad (7, "Ciudad de Santiago del Estero"),
                new Ciudad (8, "San Miguel de Tucuman"),
                new Ciudad (9, "Salta"),
                new Ciudad (10, "Mendoza"),
            };
           Console.WriteLine("Ingrese tres letras para buscar coincidencia");
           string rta = Console.ReadLine();
            var city = from d in list
                       where SqlMethods.Like(d.Nombre, "% + rta + %") 
                       select d;
            foreach (var a in city)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        } 
        public class Ciudad
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }

            public Ciudad (int Codigo, string Nombre)
            {
                this.Codigo = Codigo;
                this.Nombre = Nombre;  
            }
            public int ImprimirCod()
            {
                return Codigo;
            }
        }
   }
}
