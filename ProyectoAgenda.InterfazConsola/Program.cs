using System;
using System.Linq;
using ProyectoAgenda.Servicios.Entities;

namespace ProyectoAgenda.InterfazConsola
{
    internal class Program
    {
        public static void Main()
        {
            int opcionMenu;
            Agenda agenda = new Agenda("Agenda", "agenda", 100);

            do
            {
                Console.Clear();
                Console.WriteLine("Agenda:");
                Console.WriteLine("1- Listar contactos:");
                Console.WriteLine("2- Consultar contacto:");
                Console.WriteLine("3- Agregar contacto:");
                Console.WriteLine("4- Eliminar contacto:");
                Console.WriteLine("5- Llamar contacto:");
                Console.WriteLine("6- Ver contacto mas llamado:");
                Console.WriteLine("0- Salir");
                opcionMenu = InputHelper.PedirNumeroNatural("Ingresar una opcion:", 0, 6);

                switch (opcionMenu)
                {
                    case 1: // Listar contactos
                    {
                        Console.WriteLine("Lista de contactos:");
                        int i = 1;
                        foreach (Contacto contacto in agenda.Contactos)
                        {
                            Console.WriteLine($"{i}- {contacto}");
                            i++;
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }

                    case 2: // Consultar contacto
                    {
                        int i = InputHelper.PedirNumeroNatural(
                            "Ingresar posicion del contacto en la lista de contactos:", 1
                        );
                        try
                        {
                            Console.WriteLine(agenda.TraerContactoPorPosicion(i));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"No hay un contacto en la posicion {i}");
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }

                    case 3: // Agregar contacto
                    {
                        if (agenda.Contactos.Count() >= agenda.CantidadMaximaContactos)
                        {
                            InputHelper.PedirContinuacion("Agenda llena");
                            break;
                        }

                        string nombre = InputHelper.PedirString("Ingresar nombre:");
                        string apellido = InputHelper.PedirString("Ingresar apellido:");
                        string telefono = InputHelper.PedirString("Ingresar telefono:");
                        string direccion = InputHelper.PedirString("Ingresar direccion:");
                        DateTime fechaNacimiento = InputHelper.PedirStringFecha("Ingresar fecha de nacimiento (dia/mes/ano):");

                        Contacto nuevoContacto =
                            new ContactoPersona(nombre, apellido, telefono, direccion, fechaNacimiento);

                        try
                        {
                            agenda.AgregarContacto(nuevoContacto);
                            Console.WriteLine("Contacto agregado");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Agenda llena");
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }

                    case 4: // Eliminar contacto
                    {
                        int i = InputHelper.PedirNumeroNatural(
                            "Ingresar posicion del contacto a eliminar en la lista de contactos:", 1
                        );
                        try
                        {
                            agenda.EliminarContacto(i);
                            Console.WriteLine("Contacto eliminado");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"No hay un contacto en la posicion {i}");
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }

                    case 5: // Llamar contacto
                    {
                        int i = InputHelper.PedirNumeroNatural(
                            "Ingresar posicion del contacto en la lista de contactos:", 1
                        );
                        try
                        {
                            Contacto contacto = agenda.TraerContactoPorPosicion(i);
                            contacto.Llamar();
                            Console.WriteLine($"Contacto {contacto}llamado");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"No hay un contacto en la posicion {i}");
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }
                    case 6: // Ver contacto mas llamado
                    {
                        try
                        {
                            Contacto contacto = agenda.TraerContactoFrecuente();
                            Console.WriteLine("Contacto mas llamado:");
                            Console.WriteLine(contacto);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"No hay contactos para mostrar");
                        }

                        InputHelper.PedirContinuacion();
                        break;
                    }
                    case 0: // Salir
                    {
                        Console.WriteLine("Salir del programa");
                        break;
                    }
                }
            } while (opcionMenu != 0);
        }
    }
}
