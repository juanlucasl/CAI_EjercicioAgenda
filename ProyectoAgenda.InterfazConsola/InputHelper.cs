using System;

namespace ProyectoAgenda.InterfazConsola
{
    /// <summary>
    /// Clase helper para pedido de inputs.
    /// </summary>
    public static class InputHelper
    {
        /// <summary>
        /// Solicita al usuario que ingrese un numero natural. Una vez que el usuario ingreso lo pedido, devuelve el
        /// valor. Opcionalmente recibe un mensaje para mostrar al usuario, un numero minimo y un numero maximo.
        /// </summary>
        /// <param name="mensaje" type="string">
        /// Mensaje para mostrarle al usuario antes de que ingrese el numero (default "Ingresar un numero natural")
        /// </param>
        /// <param name="min" type="int">
        /// Valor minimo para el numero que el usuario puede ingresar (default 0)
        /// </param>
        /// <param name="max" type="int">
        /// Valor maximo para el numero que el usuario puede ingresar (default 2147483647)
        /// </param>
        /// <returns type="int">El número que ingresó el usuario</returns>
        public static int PedirNumeroNatural(
            string mensaje = "Ingresar un numero natural",
            int min = 0,
            int max = Int32.MaxValue
        )
        {
            int numeroNatural;

            Console.WriteLine(mensaje);
            while (!int.TryParse(Console.ReadLine(), out numeroNatural) || numeroNatural < min || numeroNatural > max)
            {
                Console.WriteLine("El numero ingresado no es valido. Ingresar un numero distinto:");
            }

            return numeroNatural;
        }

        /// <summary>
        /// Solicita al usuario que ingrese texto. Valida que el texto ingresado no este vacio.
        /// </summary>
        /// <param name="mensaje" type="string">
        /// Mensaje para mostrarle al usuario antes de que ingrese el text (default "Ingresar texto")
        /// </param>
        /// <returns type="string">El texto que ingreso el usuario</returns>
        public static string PedirString(string mensaje = "Ingresar texto")
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        /// <summary>
        /// Solicita al usuario que ingrese una fecha. Devuelve la fecha del dia de hoy si el usuario deja el campo
        /// vacio.
        /// </summary>
        /// <param name="mensaje" type="string">
        /// Mensaje para mostrarle al usuario antes de que ingrese la fecha (default "Ingresar fecha")
        /// </param>
        /// <returns type="Date">La fecha que ingreso el usuario</returns>
        public static DateTime PedirStringFecha(string mensaje = "Ingresar fecha")
        {
            DateTime inputDate;
            string input;
            Console.WriteLine(mensaje);
            while (!DateTime.TryParse(input = Console.ReadLine(), out inputDate))
            {
                if (input == "") return DateTime.Today;
                Console.WriteLine("La fecha ingresada no es valida. Ingresar una fecha distinta:");
            }

            return inputDate;
        }

        /// <summary>Pide que presione una tecla para continuar.</summary>
        /// <param name="mensaje" type="string">Mensaje para mostrar al usuario.</param>
        public static void PedirContinuacion(string mensaje = "")
        {
            if(!string.IsNullOrWhiteSpace(mensaje)) Console.WriteLine(mensaje);
            Console.WriteLine("Presionar una tecla para continuar");
            Console.ReadKey();
        }
    }
}
