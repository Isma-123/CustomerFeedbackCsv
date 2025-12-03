using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{

    [Table("DIM_PRODUCTO", Schema = "dbo")]
    public class DimProducto
        {

        [Key]
        
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
    }
}
