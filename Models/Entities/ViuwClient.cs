using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadClientsComments.cs.Models.Entities
{


    [Table("CLIENTS", Schema = "dbo")]
    public class ViuwClient
    {

        [Key]
        public int IdCliente { get; set; } = 0; 
        [Required]
        public string? NOMBRE { get; set;  }
        [Required]
        public string? EMAIL { get; set; }
    }
}
