using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Instituicao
{
    public class InstituicaoResponse : EntidadeResponseBase
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
