using System;

namespace ProyectoAgenda.Servicios.Entities
{
    public class ContactoEmpresa : Contacto
    {
        // Constructor
        public ContactoEmpresa(string razonSocial, string telefono, string direccion, DateTime fechaConstitucion) : base(telefono, direccion, fechaConstitucion)
        {
            _razonSocial = razonSocial;
        }

        // Atributos
        private readonly string _razonSocial;

        // Propiedades
        private int Antiguedad
        {
            get { return FechaDiff(); }
        }

        public override string ToString()
        {
            return $"Empresa: {_razonSocial} ({Antiguedad} años)\n{Telefono}\n{Direccion}\n";
        }
    }
}
