using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBiblioteca
{
    internal interface ISecurity
    {

        string mostrar_tipo_seguridad();
        bool esta_asegurado();

    }
}
