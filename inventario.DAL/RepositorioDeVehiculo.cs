using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inventario.DAL
{
    public class RepositorioDeVehiculo : IRepositorio<Vehiculo>
    {
        private string DBName = "inventario.db";
        private string TableName = "Vehiculo";
        public List<Vehiculo> Read
        {
            get
            {
                List<Vehiculo> datos = new List<Vehiculo>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Vehiculo>(TableName).FindAll
                    ().ToList();
                }
                return datos;
            }
        }
        public bool Create(Vehiculo entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Vehiculo>(TableName);
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
                    var coleccion = db.GetCollection<Vehiculo>(TableName);
                    r = coleccion.Delete(e => e.Id == id);
                }
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Vehiculo entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Vehiculo>(TableName);
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
