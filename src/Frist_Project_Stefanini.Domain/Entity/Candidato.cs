using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Frist_Project_Stefanini.Domain.Entity
{
    [Table("TB_CANDIDATO")]
    public class Candidato : EntityBase
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string telefonePrimario {get;set;}
        public string telefoneSecundario { get; set; }
        public string CPF { get; set; }
        public DateTime Datalog { get; set; }
        public string Usuario { get; set; }
    }
}
