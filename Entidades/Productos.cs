using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Productos_Detalle.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        public string Descripcion { get; set; }
        
        public double Existencia { get; set; }
        
        public double Costo { get; set; }

        public double ValorInventario { get; set; }

        public double Ganancia { get; set; }

        public double Precio { get; set; }

        [ForeignKey("ProductoId")]
        public List<ProductosDetalle> Detalle { get; set; } = new List<ProductosDetalle> ();

    }

}