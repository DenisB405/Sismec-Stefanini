using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Instituicao
{
    public class InstituicaoRequest : EntidadeRequestBase
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
    }
}
