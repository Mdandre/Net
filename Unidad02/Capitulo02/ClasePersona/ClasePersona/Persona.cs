using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
    public class Persona
    {
        private String _nombre;
        private String _apellido;
        private int _edad;
        private int _DNI;
        private DateTime _fechaNac;

        public Persona(String nombre, String apellido, int edad, int DNI, DateTime fechaNac)
        {

            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = GetAge(fechaNac, DateTime.Now);
            this._DNI = DNI;
            this._fechaNac = fechaNac;
            Console.WriteLine("Persona creada");
            Console.WriteLine();
        }
        ~Persona()
        {
            Console.WriteLine("Datos persona destruidos");
        }
        public void GetFullName(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            Console.WriteLine(nombre, apellido);
        }
        public int GetAge(DateTime fechaNac, DateTime now)
        {
            int edad = now.Year - fechaNac.Year;
            if (now.Month < fechaNac.Month || (now.Month == fechaNac.Month && now.Day < fechaNac.Day))
                edad--;
            return edad;
        }

        public string apellido
        {
            get => default;
            set
            {
            }
        }

        public string nombre
        {
            get => default;
            set
            {
            }
        }

        public int edad
        {
            get => default;
            set
            {
            }
        }

        public int DNI
        {
            get => default;
            set
            {
            }
        }

        public DateTime fechaNac
        {
            get => default;
            set
            {
            }
        }
    }
}


