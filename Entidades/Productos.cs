using System;
using System.Collections.Generic;
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

        [Required(ErrorMessage = "El Costo es obligatorio")]
        [Range(1,float.MaxValue,ErrorMessage = "El costo debe estar entre los datos permitidos")]
        public float Costo { get; set; }

        [Required(ErrorMessage = "La Ganancia es obligatorio")]
        [Range(1,float.MaxValue,ErrorMessage = "La Ganancia debe estar entre los datos permitidos")]
        public float Ganancia { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        [Range(1,float.MaxValue,ErrorMessage = "El Precio debe estar entre los datos permitidos")]
        public float Precio { get; set; }

        [ForeignKey("ProductoId")]
        public List<ProductosDetalle> Detalle { get; set; } = new List<ProductosDetalle> ();
    }

    public class ProductosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }

        public string Presentacion { get; set; }

        public float Precio { get; set; }

    }

}