using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Contexto;
using API2.Models;
using API2.Repositorio;
using API2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {

        private IAluno _ialunos;
        public AlunosController(IAluno ialunos)
        {
            _ialunos = ialunos;
        }


        [HttpGet]

        public IActionResult Get()
        {
          return  Ok(_ialunos.FindAll());
        }

        [HttpGet("id")]

        public IActionResult Get(long id)
        {
            var alunos = _ialunos.GetById(id);
            if(alunos == null)
            {
                return NotFound();
            }

            return Ok(alunos);
        }


        [HttpPost]

       public IActionResult Post([FromBody] Alunos aluno)
        {
            if(aluno == null)
            {
                return BadRequest();
            }

            return Ok(_ialunos.Create(aluno));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Alunos aluno)
        {
            if (aluno == null)
            {
                return BadRequest();
            }

            return Ok(_ialunos.Update(aluno));
        }


        [HttpDelete("id")]

        public IActionResult Delete(long id)
        {
           _ialunos.Delete(id);
          
            return NoContent();
        }



    }
}
