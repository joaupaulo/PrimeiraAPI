using API2.Contexto;
using API2.Models;
using API2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Services
{
    public class AlunosService : IAluno
    {

        private AlunosContext _contexto;

        public AlunosService(AlunosContext contexto)


        {
            _contexto = contexto;
        }


        public Alunos Create(Alunos alunos)
        {
            try
            {
                _contexto.Add(alunos);
                _contexto.SaveChanges();
            }

            catch (Exception)
            {
                throw;

            }

            return alunos;

        }

        public void Delete(long id)
        {


            var result = _contexto.Alunoss.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _contexto.Alunoss.Remove(result);
                    _contexto.SaveChanges();
                }

                catch (Exception)
                {
                    throw;

                }

            }



        }

        public List<Alunos> FindAll()
        {
           return _contexto.Alunoss.ToList();
        }

        public Alunos GetById(long id)
        {
            return _contexto.Alunoss.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Alunos Update(Alunos alunos)
        {
            if (!Exists(alunos.Id)) return new Alunos();

            var result = _contexto.Alunoss.SingleOrDefault(p => p.Id.Equals(alunos.Id));

            if (result != null)
            {
                try
                {
                    _contexto.Entry(result).CurrentValues.SetValues(alunos);
                    _contexto.SaveChanges();
                }

                catch (Exception)
                {
                    throw;

                }



            }
            return alunos;
        }

        private bool Exists(long id)
        {
             return _contexto.Alunoss.Any(p => p.Id.Equals(id));
        }


    }
}
