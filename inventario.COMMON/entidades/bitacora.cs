using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.entidades
{
    public class bitacora : @base
    {
        public DateTime FechaHoraSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<inventario> PiezasUsadas { get; set; }
        public cliente Solicitante { get; set; }
        public empleado EncargadoBodega { get; set; }
    }
}
