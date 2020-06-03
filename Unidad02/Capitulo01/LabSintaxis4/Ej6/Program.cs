using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int numeroEntero;
                do
                {
                    Console.Clear();
                    Console.Write("Ingrese un numero entero que este dentro del intervalo [0 - 3000]: ");
                    numeroEntero = int.Parse(Console.ReadLine());
                    if (numeroEntero > 3000)
                    {
                        Console.WriteLine("El numero ingresado esta fuera del intervalo establecido, presione una tecla para continuar...");
                        Console.ReadKey();
                    }
                } while (!(numeroEntero >= 0 & numeroEntero <= 3000));

                Console.WriteLine("El Entero:  " + numeroEntero + "   equivale a    " + EnteroARomano(numeroEntero) + " en número romano");
                Console.Write("\nPresione Esc para salir...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static string EnteroARomano(int numeroEntero)
        {
            StringBuilder numeroRomano = new StringBuilder();

            while (numeroEntero >= 1000)
            {
                numeroRomano.Append("M");
                numeroEntero -= 1000;
            }
            if (numeroEntero >= 900)
            {
                numeroRomano.Append("CM");
                numeroEntero -= 900;
            }
            if (numeroEntero >= 500)
            {
                numeroRomano.Append("D");
                numeroEntero -= 500;
            }
            if (numeroEntero >= 400)
            {
                numeroRomano.Append("CD");
                numeroEntero -= 400;
            }
            while (numeroEntero >= 100)
            {
                numeroRomano.Append("C");
                numeroEntero -= 100;
            }
            if (numeroEntero >= 90)
            {
                numeroRomano.Append("XC");
                numeroEntero -= 90;
            }
            if (numeroEntero >= 50)
            {
                numeroRomano.Append("L");
                numeroEntero -= 50;
            }
            if (numeroEntero >= 40)
            {
                numeroRomano.Append("XL");
                numeroEntero -= 40;
            }
            while (numeroEntero >= 10)
            {
                numeroRomano.Append("X");
                numeroEntero -= 10;
            }
            if (numeroEntero >= 9)
            {
                numeroRomano.Append("IX");
                numeroEntero -= 9;
            }
            if (numeroEntero >= 5)
            {
                numeroRomano.Append("V");
                numeroEntero -= 5;
            }
            if (numeroEntero >= 4)
            {
                numeroRomano.Append("IV");
                numeroEntero -= 4;
            }
            while (numeroEntero >= 1)
            {
                numeroRomano.Append("I");
                numeroEntero -= 1;
            }

            return numeroRomano.ToString();
        }
    }
}
