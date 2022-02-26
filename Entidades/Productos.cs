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

        [Required(ErrorMessage = "El campo Existencia esta Vacio...")]
        [Range(1,int.MaxValue,ErrorMessage = "La Existencia debe estar entre los datos permitidos")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "El campo Costo esta Vacio...")]
        [Range(1,double.MaxValue,ErrorMessage = "El costo debe estar entre los datos permitidos")]
        public double Costo { get; set; }

        public double ValorInventario { get; set; }

        [Required(ErrorMessage = "El campo Ganancia esta Vacio...")]
        [Range(1,double.MaxValue,ErrorMessage = "La Ganancia debe estar entre los datos permitidos")]
        public double Ganancia { get; set; }

        [Required(ErrorMessage = "El campo Precio esta Vacio...")]
        [Range(1,double.MaxValue,ErrorMessage = "El Precio debe estar entre los datos permitidos")]
        public double Precio { get; set; }

        [ForeignKey("ProductoId")]
        public List<ProductosDetalle> Detalle { get; set; } = new List<ProductosDetalle> ();
    }

}