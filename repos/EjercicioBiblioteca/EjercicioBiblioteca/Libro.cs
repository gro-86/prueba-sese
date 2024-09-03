using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBiblioteca 
{
    internal class Libro : Material,ISecurity
    {

        private int num_paginas;

        public Libro(string titulo,string autor, int anio_publicacion, string editorial, int num_paginas) : base(titulo,autor,anio_publicacion,editorial) {
            this.num_paginas = num_paginas;
        }

        public int Num_Paginas { 
        
            get { return num_paginas; } 
            set { num_paginas = value; }
        
        }

        public string mostrar_tipo_seguridad() {


            return "Tipo de seguridad: Alta";
        }
        public bool esta_asegurado() { 
        
            return true;
        
        }

        public override string mostrar_tipo_material()
        {

            return "El material del libro es sintético";
        }
        public override string mostrar_estado_material()
        {


            return "El material está recien salido de la fábrica";
        }

        public override string ToString() {

            
            return "\n------------------------------------" +
                base.ToString()+"\nNúmero de páginas: "+num_paginas+
                "\n------------------------------------";
        
        }

    }
}
