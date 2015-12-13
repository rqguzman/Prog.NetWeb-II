using System.Collections.Generic;

namespace Av1_Domain.Entidades
{
    public class GeneroDaSerie
    {
        public int GeneroDaSerieId { get; set; }

        public string NomeDoGenero { get; set; }

        public virtual ICollection<Serie> SeriesDoGenero { get; set; }

        public GeneroDaSerie()
        {
            SeriesDoGenero = new List<Serie>();
        }
    }
}
