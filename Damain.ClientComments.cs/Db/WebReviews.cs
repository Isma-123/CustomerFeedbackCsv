using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain.ClientComments.cs.Db
{
    public class WebReviews
    {
        public int IdReview { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Rating { get; set; }
    }

}
