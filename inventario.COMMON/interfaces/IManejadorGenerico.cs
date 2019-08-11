using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.interfaces
{
    public interface IManejadorGenerico<T> where T:Base
    {
        bool Agregar(T entidad);
        List<T> Listar { get; }
        bool Eliminar(string id);
        bool Modificar(T entidad);
        T BuscarPorId(string id);
    }
}
