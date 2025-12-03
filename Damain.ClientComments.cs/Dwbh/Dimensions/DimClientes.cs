

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Damain.ClientComments.cs.Dwbh.Dimensions
{

    [Table("DIM_CLIENTE", Schema = "dbo")]
    public class DimClientes
    {

        [Key]
        public int IdCliente { get; set; }  
        public string? Nombre { get; set; } 
        public string? Email { get; set; } 

    }
}
