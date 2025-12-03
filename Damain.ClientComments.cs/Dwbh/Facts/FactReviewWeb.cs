using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Facts
{
    public class FactReviewWeb
    {
        public int IdReview { get; set; }
        public int IdCliente { get; set; }
        public int IdWeb { get; set; }
        public int IdProducto { get; set; }
        public int IdTiempo { get; set; }
        public int IdFuente { get; set; }

        /// <summary>Rating numérico (ej. 1-5).</summary>
        public int? Rating { get; set; }

        /// <summary>Tipo de opinión: "Positiva", "Negativa", "Neutral", etc.</summary>
        public string TipoOpinion { get; set; } = string.Empty;
    }
}
