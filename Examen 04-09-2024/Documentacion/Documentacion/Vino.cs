using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentacion
{/// <summary>
/// Clase Vino
/// </summary>
    public class Vino
    {
        /// <summary>
        /// Atributo nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Atributo tipo
        /// </summary>
        public string Tipo { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        public Vino(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
        /// <summary>
        /// Función de muestra de datos
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Vino: {Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
        }

    }
}
