using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    public class Vino
    {

        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Vino(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }

        public string MostrarInformacion(Vino vino)
        {
            
            return vino.Tipo;
        }

    }
}
