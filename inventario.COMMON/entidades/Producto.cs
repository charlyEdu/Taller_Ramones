using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    class Producto : Base
    {
        
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

    }
}
