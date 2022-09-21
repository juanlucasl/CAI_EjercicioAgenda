using System;

namespace ProyectoAgenda.Servicios.Entities
{
    public class ContactoEmpresa : Contacto
    {
        // Constructor
        public ContactoEmpresa(string razonSocial, string telefono, string direccion, DateTime fechaConstitucion) : base(direccion, fechaConstitucion)
        {
            _razonSocial = razonSocial;
            _telefono = telefono;
        }

        // Atributos
        private readonly string _razonSocial;
        private readonly string _telefono;

        // Propiedades
        private int Antiguedad
        {
            get { return FechaDiff(); }
        }

        public override string ToString()
        {
            return $"Empresa: {_razonSocial} ({Antiguedad} años)\n{_telefono}\n{Direccion}\n";
        }
    }
}
