using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    public class Empleado : Base
    {
        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Area { get; set; }
        

    }
}
