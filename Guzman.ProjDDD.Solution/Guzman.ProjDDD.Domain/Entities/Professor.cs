using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.ProjDDD.Domain.Entities
{
    public class Professor
    {
        public String ProfessorId { get; set; }

        public String Nome { get; set; }

        public Professor()
        {
            ProfessorId = Guid.NewGuid().ToString();
        }
    }
}
