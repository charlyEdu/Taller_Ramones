using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inventario.DAL
{
    public class RepositorioDeBitacora : IRepositorio<Bitacora>
    {
        private string DBName = "inventario.db";
        private string TableName = "Bitacora";
        public List<Bitacora> Read
        {
            get
            {
                List<Bitacora> datos = new List<Bitacora>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Bitacora>(TableName).FindAll
                    ().ToList();
                }
                return datos;
            }
        }
        public bool Create(Bitacora entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Bitacora>(TableName);
                    coleccion.Insert(entidad);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                int r;
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Bitacora>(TableName);
                    r = coleccion.Delete(e => e.Id == id);
                }
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Bitacora entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Bitacora>(TableName);
                    coleccion.Update(entidadModificada);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
