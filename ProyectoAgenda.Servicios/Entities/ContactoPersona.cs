using System;

namespace ProyectoAgenda.Servicios.Entities
{
    public class ContactoPersona : Contacto
    {
        // Constructor
        public ContactoPersona(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento) : base(telefono, direccion, fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        // Atributos
        private readonly string _nombre;
        private readonly string _apellido;

        // Propiedades
        private int Edad
        {
            get { return FechaDiff(); }
        }

        // Metodos
        public override string ToString()
        {
            return $"Persona: {_nombre} {_apellido} ({Edad} años)\n{Telefono}\n{Direccion}\n";
        }
    }
}
