﻿using inventario.COMMON.entidades;
using inventario.COMMON.interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inventario.DAL
{
    public class RepositorioDeProducto : IRepositorio<Producto>
    {
        private string DBName = "inventario.db";
        private string TableName = "Producto";
        public List<Producto> Read
        {
            get
            {
                List<Producto> datos = new List<Producto>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Producto>(TableName).FindAll
                    ().ToList();
                }
                return datos;
            }
        }
        public bool Create(Producto entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Producto>(TableName);
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
                    var coleccion = db.GetCollection<Producto>(TableName);
                    r = coleccion.Delete(e => e.Id == id);
                }
                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Producto entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Producto>(TableName);
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
