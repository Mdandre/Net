using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese contraseña numerica:");
            string contraseña = Console.ReadLine();
            int intentos = 0;
            Console.WriteLine("La contraseña es   " + contraseña + "....\n\n");
            while (intentos < 4)
            {
                intentos++;
                Console.WriteLine("Ingrese la constraseña: ");
                string contraIng = Console.ReadLine();
                if (contraseña == contraIng)
                {
                    Console.WriteLine("Clave correcta...FIN");
                    Console.ReadKey();
                    break;
                }
                else if (contraseña != contraIng)
                {
                    Console.WriteLine("Clave incorrecta... intento" + intentos);
                        if (intentos == 4)
                        {
                            Console.WriteLine("Número máximo de intentos alcanzado. FIN.");
                            Console.ReadKey();
                        }
                }
                 
            }
        }
    }
}
