using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.ProjDDD.Domain.Entities
{
    public class Aluno
    {
        public String AlunoId { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataHoraCadastro { get; set; }

        public Aluno()
        {
            AlunoId = Guid.NewGuid().ToString();
        }
    }
}
