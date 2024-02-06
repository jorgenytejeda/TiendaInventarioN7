using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario.Modelos
{
   public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Required Name")]
        [MaxLength(50, ErrorMessage ="Max Name 50 caracters")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Required Description")]
        [MaxLength(100, ErrorMessage = "Max Description 50 caracters")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Required State")]
        public bool Estado { get; set; }
    }
}
