﻿using System;
using System.Collections.Generic;
using Av1_Domain.Enums;

namespace Av1_Domain.Entidades
{
    public class Serie
    {
        public int SerieId { get; set; }

        public string NomeSerie { get; set; }

        public string CriadorDaSerie { get; set; }

        public StatusDaSerie StatusDaSerie { get; set; }

        public string Sinopse { get; set; }

        public DateTime Horario { get; set; }

        //FotoDeCapaSerie

        public int PaisDeOrigemId { get; set; }

        public virtual PaisDeOrigemSerie PaisDeOrigemSerie { get; set; }

        public int CanalId { get; set; }

        public virtual CanalDeTv CanalDeTv { get; set; }

        public ICollection<GeneroDaSerie> GenerosDaSerie { get; set; }

        public ICollection<Temporada> TemporadasDestaSerie { get; set; }

        public Serie()
        {
            this.TemporadasDestaSerie = new List<Temporada>();
        }
    }
}
