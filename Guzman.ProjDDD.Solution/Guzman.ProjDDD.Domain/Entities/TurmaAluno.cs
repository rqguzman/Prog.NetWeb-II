using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.ProjDDD.Domain.Entities
{
    public class TurmaAluno
    {
        public String TurmaAlunoId { get; set; }

        public DateTime DataInscricao { get; set; }

        public TurmaAluno()
        {
            TurmaAlunoId = Guid.NewGuid().ToString();
        }
    }
}
