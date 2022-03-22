using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class cliente
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public String Correo { get; set; }

        public string Clave { get; set; }

        public bool Restablecer { get; set; }

    }
}
