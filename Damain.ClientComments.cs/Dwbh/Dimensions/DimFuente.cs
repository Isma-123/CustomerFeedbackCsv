using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{

    [Table("DIM_FUENTE", Schema = "dbo")]
    public class DimFuente
    {

        [Key]
        public int IdFuente { get; set; }   
        public string? TipoFuente { get; set; }     


    }
}
