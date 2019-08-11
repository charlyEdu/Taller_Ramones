using inventario.COMMON.interfaces;
using inventario.COMMON.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.BIZ
{
    public class ManejadorBitacora : IManejadorBitacora
    {
        IRepositorio<Bitacora> repositorio;
        public ManejadorBitacora(IRepositorio<Bitacora> repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<Bitacora> Listar => repositorio.Read;
        
        public bool Agregar(Bitacora entidad)
        {
            return repositorio.Create(entidad);
        }
        
        public Bitacora BuscarPorId(string id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Bitacora entidad)
        {
            return repositorio.Update(entidad);
        }      
    }
}
