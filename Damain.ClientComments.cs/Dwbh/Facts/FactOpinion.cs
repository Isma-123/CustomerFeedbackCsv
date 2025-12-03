using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Dwbh.Facts
{
    public class FactOpinion
    {
        public int IdOpinion { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int IdFuente { get; set; }
        public int IdTiempo { get; set; }
        public int IdSocial { get; set; }
        public int IdSurvey { get; set; }
        public int IdWeb { get; set; }
        public string? TipoOpinion { get; set; }
    }
}
