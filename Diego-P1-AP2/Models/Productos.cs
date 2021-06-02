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

        public String Descripcion { get; set; }

        public int Existencia { get; set; }

        public float Costo { get; set; }

        public float ValorInventario { get; set; }

    }
}
