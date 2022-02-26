using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Productos_Detalle.DAL;
using Productos_Detalle.Entidades;

namespace Productos_Detalle.BLL
{
    public class ProductosBLL
    {
        
        public static bool Guardar(Productos producto)
        {
            if (!ExisteDescripcion(producto.Descripcion))
                return Insertar(producto);
            else 
                return Modificar(producto);
        }

        private static bool Insertar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Productos.Add(producto);
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var producto = contexto.Productos.Find(id);

                if (producto != null)
                {
                    contexto.Productos.Remove(producto);
                    paso = contexto.SaveChanges() > 0;
                }
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

        public static Productos Buscar(int id)
        {
            Productos producto;
            Contexto contexto = new Contexto();

            try
            {
                producto = contexto.Productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return producto;
        }

        public static bool ExisteDescripcion(string descripcion)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Productos.Any(p => p.Descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Productos.Any(p => p.ProductoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            
            List<Productos> lista = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

    }
}