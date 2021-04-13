using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Repositorio
{
   public interface IAluno
    {

        Alunos Create(Alunos alunos);
        Alunos GetById(long id);

        List<Alunos> FindAll();
        Alunos Update(Alunos alunos);

        void Delete(long id);
    }
}
