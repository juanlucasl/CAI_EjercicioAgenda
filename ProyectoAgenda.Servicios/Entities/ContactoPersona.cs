using System;

namespace ProyectoAgenda.Servicios.Entities
{
    public class ContactoPersona : Contacto
    {
        // Constructor
        public ContactoPersona(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento) : base(direccion)
        {
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _fechaNacimiento = fechaNacimiento;
        }

        // Atributos
        private readonly string _nombre;
        private readonly string _apellido;
        private readonly string _telefono;
        private DateTime _fechaNacimiento;

        // Propiedades
        public string Nombre
        {
            get { return _nombre; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        private int Edad
        {
            get
            {
                int age = DateTime.Today.Year - _fechaNacimiento.Year;
                if (DateTime.Today < _fechaNacimiento.AddYears(age)) age--;

                return age;
            }
        }

        // Metodos
        public override string ToString()
        {
            return $"{_nombre} {_apellido} ({Edad} años)\n{_telefono}\n{Direccion}\n";
        }
    }
}
