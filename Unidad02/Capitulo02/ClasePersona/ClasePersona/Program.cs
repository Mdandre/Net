using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
        class Program
        {
            static void Main(string[] args)
            {

                Persona persona = new Persona("Marco ", " D'Andrea", 38819439,new DateTime(1995, 04, 07));
                Console.WriteLine("Nombre completo: " + persona.GetFullName());
                Console.WriteLine("Edad: " + persona.GetAge());
                Console.ReadKey();
            }
        }
}


