﻿using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    public class cliente : @base
    {
        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Empresa { get; set; }
        public string Identificacion { get; set; }

    }
}
