using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadClientsComments.cs.Models.Entities
{
    [Table("PRODUCTS", Schema = "dbo")] 
    
    public class ViuwProducts
    {


        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
    }
}
