using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guzman.ProjDDD.Domain.Entities;
using Guzman.ProjDDD.Infra.Data.Context;

namespace Guzman.ProjDDD.Infra.Data.Repositories
{
    public class AlunoRepository
    {
        private readonly EntidadesContext _dbContext;

        public AlunoRepository()
        {
            _dbContext = new EntidadesContext();
        }

        public IEnumerable<Aluno> ObterTodos()
        {
            return _dbContext.Alunos.ToList();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            _dbContext.Alunos.Add(aluno);
            _dbContext.SaveChanges();
        } 
        
    }
}
