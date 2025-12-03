using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{

    [Table("DIM_SURVEY", Schema = "dbo" )]
    public class DimSurvey
    {

        [Key]    


        public int IdSurvey { get; set; }   

        public string? Comentario { get; set; } 

        public string? Clasificacion { get; set; }  

        public int PuntajeSatisfaccion { get; set; }    


    }
}
