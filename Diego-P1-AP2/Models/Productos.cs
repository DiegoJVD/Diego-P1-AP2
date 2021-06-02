using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Diego_P1_AP2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Es Obligatorio introducir la descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Es Obligatorio introducir la Existencia")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "Es Obligatorio introducir el costo")]
        public float Costo { get; set; }

        public float ValorInventario { get; set; }

    }
}
