﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Tipo oMarca { get; set; }

        public Categoria oCategoria { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string RutaImagen { get; set; }

        public String NombreImagen { get; set; }

        public bool activo { get; set; }




    }

}
