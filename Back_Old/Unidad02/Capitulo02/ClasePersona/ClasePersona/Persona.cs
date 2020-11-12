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
        private int _DNI;
        private DateTime _fechaNac;

        public Persona(String nombre, String apellido, int DNI, DateTime fechaNac)
        {
            _nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            _apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            _fechaNac = fechaNac;
            _DNI = DNI;
            Console.WriteLine("Persona creada");
        }
        ~Persona()
        {
            Console.WriteLine("Datos persona destruidos");
        }
        public string GetFullName()
        {
            return _nombre + _apellido;
        }
        public int GetAge()
        {
            int edad = DateTime.Now.Year - _fechaNac.Year;
            if (DateTime.Now.Month < _fechaNac.Month || (DateTime.Now.Month == _fechaNac.Month && DateTime.Now.DayOfYear < _fechaNac.Day))
                edad--;
            return edad;
        }

        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
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
            get
            {
                return _DNI;
            }
            set
            {
                _DNI = value;
            }
        }

        public DateTime fechaNac
        {
            get
            {
                return _fechaNac;
            }
            set
            {
                _fechaNac = value;
            }
        }
    }
}


