using System;
using System.Threading;

namespace ProyectoAgenda.Servicios.Entities
{
    public abstract class Contacto
    {
        // Constructor
        protected Contacto(string telefono, string direccion, DateTime fechaConcepcion)
        {
            _codigo = Interlocked.Increment(ref _codigoContador);
            _telefono = telefono;
            _direccion = direccion;
            _fechaConcepcion = fechaConcepcion;
            _llamadas = 0;
        }

        // Atributos
        private static int _codigoContador = 0;
        private readonly int _codigo;
        private readonly string _telefono;
        private readonly string _direccion;
        private readonly DateTime _fechaConcepcion;
        private int _llamadas;

        // Propiedades
        public int Llamadas
        {
            get { return _llamadas; }
            private set { _llamadas = value; }
        }

        protected string Telefono
        {
            get { return _telefono; }
        }

        protected string Direccion
        {
            get { return _direccion; }
        }

        // Metodos

        /// <summary>Incrementa el contador de llamadas en 1.</summary>
        public void Llamar()
        {
            Llamadas++;
        }

        /// <summary>Calcula la cantidad de años entre la fecha de concepcion del contacto y el ano actual.</summary>
        /// <returns>Cantidad de anos.</returns>
        protected int FechaDiff()
        {
            int anos = DateTime.Today.Year - _fechaConcepcion.Year;
            if (DateTime.Today < _fechaConcepcion.AddYears(anos)) anos--;

            return anos;
        }
    }
}
