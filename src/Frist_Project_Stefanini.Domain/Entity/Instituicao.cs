using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Frist_Project_Stefanini.ApplicarionCore.Entity
{
    [Table("Tb_instituicao")]
    public class Instituicao : EntityBase
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLog { get; set; }
        public string Usuario { get; set; }
    }
}
