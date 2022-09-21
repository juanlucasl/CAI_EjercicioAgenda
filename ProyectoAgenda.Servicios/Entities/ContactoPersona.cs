using System;

namespace ProyectoAgenda.Servicios.Entities
{
    public class ContactoPersona : Contacto
    {
        // Constructor
        public ContactoPersona(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento) : base(direccion, fechaNacimiento)
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
        private int Edad
        {
            get { return FechaDiff(); }
        }

        // Metodos
        public override string ToString()
        {
            return $"Persona: {_nombre} {_apellido} ({Edad} años)\n{_telefono}\n{Direccion}\n";
        }
    }
}
