using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    public class vehiculo:@base
    {
        
        public string Marca { get; set; }
        public string Año { get; set; }
        public string Modelo { get; set; }
        public int Kilometraje { get; set; }
        public string Diagnostico { get; set; }
       

    }
}
