using System.ComponentModel.DataAnnotations;

namespace Productos_Detalle.Entidades
{
    
    public class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }

        public string? Descripcion { get; set; }

        public double Cantidad { get; set; }
        public double Precio { get; set; }

        public ProductosDetalle(int productoId, string descripcion, double cantidad, double precio)
        {
            this.ProductoId = productoId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }

}