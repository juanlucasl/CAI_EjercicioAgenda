using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAgenda.Servicios.Entities
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
        private readonly string _nombre;
        private readonly string _tipo;
        private readonly List<Contacto> _contactos;
        private readonly int _cantidadMaximaContactos;

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

        /// <summary>Recibe un contacto y lo agrega a la lista de contactos de la agenda.</summary>
        /// <param name="contacto" type="Contacto">Contacto a agregar</param>
        public void AgregarContacto(Contacto contacto)
        {
            _contactos.Add(contacto);
        }

        /// <summary>Elimina de la lista de contactos al contacto que corresponde a la posicion dada.</summary>
        /// <param name="posicion" type="int">Posicion del contacto a eliminar, partiendo desde el 1.</param>
        /// <returns>Posicion del contacto eliminado, partiendo desde el 0</returns>
        public int EliminarContacto(int posicion)
        {
            _contactos.RemoveAt(posicion - 1);
            return posicion - 1;
        }

        /// <summary>
        /// Devuelve el contacto con la cantidad de llamadas mas alta. Si hay mas de un contacto con la mmisma
        /// cantidad, devuelve el que este primero en la lista.
        /// </summary>
        /// <returns>Contacto con la mayor cantidad de llamadas</returns>
        public Contacto TraerContactoFrecuente()
        {
            int posicion = 0;
            int maxLlamadas = 0;

            for (int i = 0; i < _contactos.Count; i++)
            {
                if (_contactos[i].Llamadas <= maxLlamadas) continue;
                maxLlamadas = _contactos[i].Llamadas;
                posicion = i;
            }

            return _contactos[posicion];
        }

        /// <summary>Devuelve el contacto que corresponde a la posicion dada.</summary>
        /// <param name="posicion" type="int">Posicion del contacto a buscar, partiendo desde el 1.</param>
        /// <returns>Contacto encontrado</returns>
        public Contacto TraerContactoPorPosicion(int posicion)
        {
            return _contactos[posicion - 1];
        }
    }
}
