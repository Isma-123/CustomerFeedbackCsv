using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{
    [Table("DIM_TIEMPO", Schema = "dbo")]
      
    public class DimTiempo
    {

        [Key]
        public int IdTiempo { get; set; }
        public DateTime Fecha { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public string? NombreMes { get; set; }
        public int Trimestre { get; set; }
    }

}
