using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{
    [Table("DIM_WEB_REVIUW", Schema = "dbo")]
    public class DimWebReviuw
    {
        [Key]  
       
        public int IdWeb { get; set; }  
        public string? Comentario { get; set; }
        public string? Rating { get; set; }     


    }
}
