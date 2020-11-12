using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1
             System.Console.WriteLine("Ingrese un texto");
             string inputTexto = Console.ReadLine();
             if (inputTexto != "vacio")
             {
                 System.Console.WriteLine("Menu: 1) texto en mayusculas 2) texto en minusculas 3) contar caracteres");
                 ConsoleKeyInfo opcion = Console.ReadKey();
                 if (opcion.Key == ConsoleKey.D1)
                 {
                     Console.Clear();
                     Console.WriteLine("El resultado es:" + "\r\n" + inputTexto.ToUpper());
                     Console.ReadKey();
                 }
                 else if (opcion.Key == ConsoleKey.D2)
                 {
                     Console.Clear();
                     Console.WriteLine("El resultado es:" + "\r\n" + inputTexto.ToLower());
                     Console.ReadKey();
                 }

                 else if (opcion.Key == ConsoleKey.D3)
                 {
                     Console.Clear();
                     int longi = inputTexto.Length;
                     Console.WriteLine("El resultado es:" + "\r\n" + longi);
                     Console.ReadKey();
                 }
                 else
                 {
                     Console.Clear();
                     Console.WriteLine("BYE BYE MY FRIEND" );
                     Console.ReadKey();
                 } 
             }*/
           
            
            /* EJERCICIO 2
            System.Console.WriteLine("Ingrese un texto");
            string inputTexto = Console.ReadLine();
            if (inputTexto != "vacio")
            {
                System.Console.WriteLine("Menu: 1) texto en mayusculas 2) texto en minusculas 3) contar caracteres");
                string eleccion = Console.ReadLine();
                int opcion = Convert.ToInt32(eleccion);
                switch (opcion)
                {
                    case 1:                        
                            Console.Clear();
                            Console.WriteLine("El resultado es:" + "\r\n" + inputTexto.ToUpper());
                            Console.ReadKey();
                            break;                        
                    case 2:                        
                            Console.Clear();
                            Console.WriteLine("El resultado es:" + "\r\n" + inputTexto.ToLower());
                            Console.ReadKey();
                            break;                        
                    case 3:                        
                            Console.Clear();
                            int longi = inputTexto.Length;
                            Console.WriteLine("El resultado es:" + "\r\n" + longi);
                            Console.ReadKey();
                            break;                        
                    default:                        
                            Console.Clear();
                            Console.WriteLine("BYE BYE MY FRIEND");
                            Console.ReadKey();
                            break;                        
                }
            }*/
        }
    }
}
