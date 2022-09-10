using System.Collections.Generic;

namespace ProyectoAgenda.Entidades
{
    public class Agenda
    {
        // Constructor
        public Agenda(string nombre, string tipo, int cantidadMaximaContactos)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaximaContactos = cantidadMaximaContactos;
            _contactos = new List<Contacto>();
        }

        // Atributos
        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaContactos;

        // Propiedades
        public string Nombre
        {
            get { return _nombre; }
        }

        public string Tipo
        {
            get { return _tipo; }
        }

        public IEnumerable<Contacto> Contactos
        {
            get { return _contactos; }
        }

        public int CantidadMaximaContactos
        {
            get { return _cantidadMaximaContactos; }
        }

        // Metodos
        public void AgregarContacto(Contacto contacto)
        {
        }

        public int EliminarContacto(int contactoClave)
        {
            return 0;
        }

        public Contacto TraerContactoFrecuente()
        {
            return null;
        }
    }
}