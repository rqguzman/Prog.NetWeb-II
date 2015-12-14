using System.Collections.Generic;

namespace Av1_Domain.Entidades
{
    public class CanalDeTv
    {
        public int CanalDeTvId { get; set; }
        public string NomeCanal { get; set; }

        public virtual ICollection<Serie> SeriesDesteCanal { get; set; }

        public CanalDeTv()
        {
            SeriesDesteCanal = new List<Serie>();
        }
    }
}
