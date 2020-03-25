using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Paginacao
{
    public class PaginacaoRequest
    {
        //Quanntidade de registro solicitado
        public int quantidade { get; set; }
        public int page { get; set; }
    }
}
