using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Paginacao
{
    public class PaginacaoResponse<TEntity> where TEntity : EntidadeResponseBase
    {
        public int qntRegistros { get; set; }
        public  IEnumerable<TEntity> listaRegistros { get; set; }
        
    }
}
