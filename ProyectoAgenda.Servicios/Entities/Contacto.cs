using System.Threading;

namespace ProyectoAgenda.Servicios.Entities
{
    public abstract class Contacto
    {
        // Constructor
        protected Contacto(string direccion)
        {
            _codigo = Interlocked.Increment(ref _codigoContador);
            _direccion = direccion;
            _llamadas = 0;
        }

        // Atributos
        private static int _codigoContador = 0;
        private readonly int _codigo;
        private readonly string _direccion;
        private int _llamadas;

        // Propiedades
        public int Llamadas
        {
            get { return _llamadas; }
            private set { _llamadas = value; }
        }

        protected string Direccion
        {
            get { return _direccion; }
        }

        // Metodos
        public void Llamar()
        {
            Llamadas++;
        }
    }
}
