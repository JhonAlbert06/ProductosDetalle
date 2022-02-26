using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Productos_Detalle.DAL;
using Productos_Detalle.Entidades;

namespace Productos_Detalle.BLL
{
    public class ProductosDetalleBLL
    {
        public static bool Guardar(Productos producto)
        {
            if (!Existe(producto.Descripcion))
                return Insertar(producto);
            else 
                return Modificar(producto);
        }

        public static bool Insertar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.Productos.Add(producto) != null);
                    paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM ProductosDetalles Where ProductoId = {producto.ProductoId}");
                foreach (var anterior in producto.Detalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                
                contexto.Entry(producto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        
    }
}