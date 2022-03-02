using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Productos_Detalle.DAL;
using Productos_Detalle.Entidades;

namespace Productos_Detalle.BLL
{
    public class ProductosBLL
    {
        private Contexto _contexto;

        private ProductosBLL(Contexto contexto)
        {
            _contexto = contexto ;
        }
        
        public bool Guardar(Productos producto)
        {
            if (!Existe(producto.Descripcion))
                return Insertar(producto);
            else 
                return Modificar(producto);
        }

        private bool Insertar(Productos producto)
        {
            bool paso = false;

            try
            {
                producto.ValorInventario = producto.Costo * producto.Existencia;
                _contexto.Productos.Add(producto);

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Productos producto)
        {
            bool paso = false;

            try
            {
                _contexto.Database.ExecuteSqlRaw($"Delete FROM ProductosDetalle where ProductoId={producto.ProductoId}");

                foreach (var anterior in producto.Detalle)
                {
                    _contexto.Entry(anterior).State = EntityState.Added;
                }

                _contexto.Entry(producto).State = EntityState.Modified;

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                var producto = _contexto.Productos.Find(id);
                if (producto != null)
                {
                    _contexto.Productos.Remove(producto);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Productos Buscar(int id)
        {
            Productos producto;

            try
            {
                producto = _contexto.Productos.Include(x => x.Detalle).Where(p => p.ProductoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public bool Existe(string descripcion)
        {
            bool está = false;

            try
            {
                está = _contexto.Productos.Any(e => e.Descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            return está;
        }

        public bool Existe(int id)
        {
             bool esta = false;

            try
            {
                esta = _contexto.Productos.Any(e => e.ProductoId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return esta;
        }

        public List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            List<Productos> lista = new List<Productos>();
            try
            {
                lista = _contexto.Productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
            return lista;
        }

    }
}