using System.Collections.Generic;

namespace Av1_Domain.Entidades
{
    public class PaisDeOrigemSerie
    {
        public int PaisDeOrigemId { get; set; }

        public string NomePaisDeOrigem { get; set; }

        public virtual ICollection<Serie> SeriesDestePais { get; set; }

        public PaisDeOrigemSerie()
        {
            this.SeriesDestePais = new List<Serie>();
        }
    }
}
