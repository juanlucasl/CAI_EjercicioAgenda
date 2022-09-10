using System;

namespace ProyectoAgenda.Entidades
{
    public class Contacto
    {
        // Constructor
        public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
            _llamadas = 0;
        }

        // Atributos
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        // Propiedades
        public string Nombre
        {
            get { return _nombre; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public string Telefono
        {
            get { return _telefono; }
        }

        public int Llamadas
        {
            get { return _llamadas; }
        }

        // Metodos
        public int Edad()
        {
            return 0;
        }

        public void Llamar()
        {
        }
    }
}