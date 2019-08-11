using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    public class Bitacora : Base
    {
        public DateTime FechaHoraSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<inventario> PiezasUsadas { get; set; }
        public Cliente Solicitante { get; set; }
        public Empleado EncargadoBodega { get; set; }
    }
}
