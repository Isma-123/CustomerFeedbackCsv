
namespace Damain.ClientComments.cs.Csv
{
    public partial class Social_Comments
    {

        /// <summary>
        /// Identificador único del comentario.
        /// </summary>
        public int IdComment { get; set; }

        /// <summary>
        /// Id del cliente que hizo el comentario.
        /// </summary>
        public int IdCliente { get; set; }

        /// <summary>
        /// Id del producto al que se refiere el comentario.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Fuente del comentario 
        /// </summary>
        public string Fuente { get; set; } = string.Empty;

        /// <summary>
        /// Fecha del comentario.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Texto del comentario social.
        /// </summary>
        public string Comentario { get; set; } = string.Empty;
    }
}
