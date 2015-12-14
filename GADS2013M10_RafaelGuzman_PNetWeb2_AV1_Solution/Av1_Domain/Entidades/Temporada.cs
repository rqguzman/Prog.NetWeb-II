using System;
using System.Collections.Generic;

namespace Av1_Domain.Entidades
{
    public class Temporada
    {
        public int TemporadaId { get; set; }

        public string NomeTemporada { get; set; }

        public DateTime DataDeEstreia { get; set; }

        public string Sinopse { get; set; }

        //Foto de Capa Temporada

        public int SerieId { get; set; }

        public virtual Serie Serie { get; set; }

        public virtual ICollection<Episodio> EpisodiosDaTemporada { get; set; }

        public Temporada()
        {
            EpisodiosDaTemporada = new List<Episodio>();
        }
    }
}
