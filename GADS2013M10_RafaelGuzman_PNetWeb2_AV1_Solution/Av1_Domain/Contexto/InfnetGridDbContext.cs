using System.Data.Entity;
using Av1_Domain.Entidades;

namespace Av1_Domain.Contexto
{
    public class InfnetGridDbContext : DbContext
    {
        public DbSet<CanalDeTv> CanaisDeTv { get; set; }

        public DbSet<Episodio> Episodios { get; set; }

        public DbSet<GeneroDaSerie> GenerosDasSeries { get; set; }

        public DbSet<PaisDeOrigemSerie> PaisesDeOrigemSeries { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Temporada> Temporadas { get; set; }

        public DbSet<TipoDeArquivo> TiposDeArquivo { get; set; }

    }
}
