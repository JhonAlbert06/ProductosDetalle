using System.ComponentModel.DataAnnotations;

namespace Productos_Detalle.Entidades
{
    
    public class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Presentacion { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public double Ganancia { get; set; }

        public ProductosDetalle()
        {
            this.Id = 0;
            this.ProductoId = 0;
            this.Presentacion = null;
            this.Cantidad = 0;
            this.Precio = 0;
        }
        public ProductosDetalle(string descripcion, double cantidad, double precio)
        {
            this.Presentacion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }

}