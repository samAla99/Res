﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }

        public cliente oCliente { get; set; }

        public Producto oProducto { get; set; }

        public int Cantidad { get; set; }

    }
}
