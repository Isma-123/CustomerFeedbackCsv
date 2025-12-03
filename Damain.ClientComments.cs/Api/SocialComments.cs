

namespace Damain.ClientComments.cs.Api
{
    public class SocialComments
    {
        public int IdComment { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string Fuente { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } 
        public string Comentario { get; set; } = string.Empty;
    }

}
