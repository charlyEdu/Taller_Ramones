using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.BIZ
{
    public class ManejadorEmpleado : IManejadorEmpleado
    {
        IRepositorio<Empleado> Repositorio;
        public ManejadorEmpleado(IRepositorio<Empleado> repo)
        {
            Repositorio = repo;
        }

        public List<Empleado> Listar => Repositorio.Read;

        public bool Agregar(Empleado entidad)
        {
            return Repositorio.Create(entidad);
        }

        public Empleado BuscarPorId(string id)
        {
            return Listar.Where (e => e.Id == id) .SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return Repositorio.Delete(id);
        }

        public bool Modificar(Empleado entidad)
        {
            return Repositorio.Update(entidad);
        }
    }
}
