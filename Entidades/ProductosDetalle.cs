using System.ComponentModel.DataAnnotations;

namespace Productos_Detalle.Entidades
{
    
    public class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }

        public ProductosDetalle()
        {
            this.Id = 0;
            this.ProductoId = 0;
            this.Descripcion = null;
            this.Cantidad = 0;
            this.Precio = 0;
        }
        public ProductosDetalle(int productoId, string descripcion, double cantidad, double precio)
        {
            this.Id = 0;
            this.ProductoId = productoId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }

}