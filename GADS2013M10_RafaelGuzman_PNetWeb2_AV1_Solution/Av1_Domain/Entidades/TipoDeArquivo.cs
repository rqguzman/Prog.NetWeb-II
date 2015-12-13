using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Av1_Domain.Entidades
{
    public class TipoDeArquivo
    {
        [Key,ForeignKey("Episodio")]
        public int EpisodioId { get; set; }

        public string NomeTipoDeArquivo { get; set; }

        public virtual Episodio Episodio { get; set; }
        
    }
}
