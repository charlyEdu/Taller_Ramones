using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.DAL
{
    public class RepositorioDeEmpleado : IRepositorio<empleado>
    {
        public List<empleado> Read => throw new NotImplementedException();

        public bool Create(empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(empleado entidadOriginal, empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
