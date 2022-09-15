using System;

namespace ProyectoAgenda.Servicios.Entities
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
        private readonly string _nombre;
        private readonly string _apellido;
        private readonly string _telefono;
        private readonly string _direccion;
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
        public override string ToString()
        {
            return $"{_nombre} {_apellido} ({Edad()} años)\n{_telefono}\n{_direccion}";
        }

        /// <summary> Devuelve la edad del contacto.</summary>
        /// <returns type="int">Edad del contacto</returns>
        public int Edad()
        {
            int age = DateTime.Today.Year - _fechaNacimiento.Year;
            if (DateTime.Today < _fechaNacimiento.AddYears(age)) age--;

            return age;
        }

        public void Llamar()
        {
            _llamadas++;
        }
    }
}
