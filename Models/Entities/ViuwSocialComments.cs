using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadClientsComments.cs.Models.Entities
{

    [Table("SOCIAL_COMMENTS", Schema = "dbo")]
    public class ViuwSocialComments
    {
        [Key]
        public int IdComment { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string Fuente { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; } = string.Empty;
    }
}
