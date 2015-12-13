using System;

namespace Av1_Domain.Entidades
{
    public class Episodio
    {
        public int EpisodioId { get; set; }

        public string NumeroDoEpisodio { get; set; }

        public string Titulo { get; set; }

        public string Sinopse { get; set; }

        public DateTime DataDeExibicao { get; set; }

        public DateTime DuracaoDoEpisodio { get; set; }

        public bool Baixado { get; set; }

        public bool Asistido { get; set; }

        public string CaminhoDoArquivo { get; set; }

        public bool Dublado { get; set; }

        public bool Legendado { get; set; }
        
        public virtual TipoDeArquivo TipoDeArquivo { get; set; }

        public int TemporadaId { get; set; }

        public virtual Temporada Temporada { get; set; }
        
    }
}
