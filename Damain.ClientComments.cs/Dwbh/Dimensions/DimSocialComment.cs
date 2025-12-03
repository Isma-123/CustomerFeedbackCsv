using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{
    [Table("DIM_SOCIAL_COMMENT", Schema = "dbo")]

    public class DimSocialComment
    {


        [Key]

        public int IdSocial { get; set; }   
        public string? Comentario { get; set; }


    }
}
