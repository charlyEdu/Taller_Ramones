using inventario.COMMON.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.interfaces
{
    public interface IRepositorio<T> where T:Base
    {
        bool Create(T entidad);
        List<T> Read { get; }
        bool Update(T entidadModificada);
        bool Delete(string id);
        

    }
}
