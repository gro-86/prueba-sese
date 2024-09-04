using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentacion
{
    /// <summary>
    /// Clase usuario
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Atributo nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Atributo correo
        /// </summary>
        public string CorreoElectronico { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="correoElectronico"></param>
        public Usuario(string nombre, string correoElectronico)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
        }
        /// <summary>
        /// Función de muestra de datos
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Usuario: {Nombre}");
            Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
        }

    }
}
