﻿using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inventario.DAL
{
    public class RepositorioDeEmpleado : IRepositorio<empleado>
    {
        private string DBName = "inventario.db";
        private string TableName = "empleado";
        public List<empleado> Read {
            get
            {
                List<empleado> datos = new List<empleado>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<empleado>(TableName).FindAll
                    ().ToList();
                }
                return datos;
            }
        }

        public bool Create(empleado entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<empleado>(TableName);
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
                    var coleccion = db.GetCollection<empleado>(TableName);
                   r = coleccion.Delete(e => e.Id == id);
                }
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(empleado entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<empleado>(TableName);
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
