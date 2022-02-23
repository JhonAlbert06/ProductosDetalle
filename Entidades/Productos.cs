using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejemplo_Clase1522022.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        public string Descripcion { get; set; }
        
        public int Existencia { get; set; }

        public float Ganancia { get; set; }

        public float Precio { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio")]
        [Range(1,int.MaxValue,ErrorMessage = "El costo debe estar entre los datos permitidos")]
        public float Costo { get; set; }

        public float ValorInventario { get; set; }

    }
}