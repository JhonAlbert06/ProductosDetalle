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
         
        [Required(ErrorMessage = "La existencia no puede estar vacio...")]
        [Range(1, double.MaxValue, ErrorMessage = "La existencia debe estar en el rango de {1} y {2}.")]
        public double Existencia { get; set; }
        
        [Required(ErrorMessage = "El campo Costo no puede estar vacio...")]
        [Range(1, double.MaxValue, ErrorMessage = "El costo debe estar en el rango de {1} y {2}.")]
        public double Costo { get; set; }

        
        public double ValorInventario { get; set; }

        public double Ganancia { get; set; }
        
        [Required(ErrorMessage = "El campo Precio no puede estar vacio...")]
        [Range(1, double.MaxValue, ErrorMessage = "El Precio debe estar en el rango de {1} y {2}.")]
        public double Precio { get; set; } 

        [ForeignKey("ProductoId")]
        public List<ProductosDetalle> Detalle { get; set; } = new List<ProductosDetalle> ();

    }

}