using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Models
{
    [Table("Alunos")]
    public class Alunos
    {

        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Matricula")]
        public int Matricula { get; set; }
        [Column("DataDeMatricula")]
        public DateTime DataDeMatricula { get; set; }
        [Column("DataDeVencimento")]
        public DateTime Vencimento { get; set; }
        [Column("UltimoTreino")]
        public DateTime UltimoTreino { get; set; }






    }
}
