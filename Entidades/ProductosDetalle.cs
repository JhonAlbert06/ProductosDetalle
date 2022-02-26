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

    }

}