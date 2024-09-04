using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentacion
{
    /// <summary>
    /// Clase Reseña
    /// </summary>
    public class Resenya
    {
        /// <summary>
        /// Atributo de tipo usuario
        /// </summary>
        public Usuario Usuario { get; set; }
        /// <summary>
        /// Atributo de tipo vino
        /// </summary>
        public Vino Vino { get; set; }
        /// <summary>
        /// Devuelve un comentario
        /// </summary>
        public string Comentario { get; set; }
        /// <summary>
        /// Calificación
        /// </summary>
        public int Calificacion { get; set; } // De 1 a 5
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="vino"></param>
        /// <param name="comentario"></param>
        /// <param name="calificacion"></param>
        public Resenya(Usuario usuario, Vino vino, string comentario, int calificacion)
        {
            Usuario = usuario;
            Vino = vino;
            Comentario = comentario;
            Calificacion = calificacion;
        }
        /// <summary>
        /// Método que devuelve los atributos
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Reseña de {Usuario.Nombre} sobre el vino {Vino.Nombre}:");
            Console.WriteLine($"Calificación: {Calificacion} estrellas");
            Console.WriteLine($"Comentario: {Comentario}");
        }

    }
}
