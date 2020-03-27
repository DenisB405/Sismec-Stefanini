using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Paginacao
{
    public class PaginacaoResponse<TEntity> where TEntity : EntidadeResponseBase
    {
        public int currentPage { get; set; }
        public int totalPages { get; set; }
        public int quantidadeTotal{ get; set; }
        public  IEnumerable<TEntity> listaRegistros { get; set; }
        
    }
}
