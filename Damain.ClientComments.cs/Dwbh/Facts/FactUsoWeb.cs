
namespace Damain.ClientComments.cs.Dwbh.Facts
{
    public class FactUsoWeb
    {
        public int IdUsoWeb { get; set; }
        public int? IdCliente { get; set; }    // opcional si es anónimo
        public int IdWeb { get; set; }         // página o recurso
        public int IdTiempo { get; set; }

        /// <summary>Tipo de interacción: "visit", "click", "download", "form_submit", etc.</summary>
        public string TipoInteraccion { get; set; } = string.Empty;

        /// <summary>Duración en segundos de la sesión/interacción.</summary>
        public int? DuracionSegundos { get; set; }
    }
}
