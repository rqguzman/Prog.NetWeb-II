using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.ProjDDD.Domain.Entities
{
    public class Turma
    {
        public String TurmaId { get; set; }

        public String Codigo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }



        public String Sala { get; set; }

        public Turma()
        {
            TurmaId = Guid.NewGuid().ToString();
        }
        
    }
}
