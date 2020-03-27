using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Paginacao
{
    public class PaginacaoResponse<TEntity> where TEntity : EntidadeResponseBase
    {
        public int currentPage { get; set; }
        public int firstPage { get; set; }
        public int lastPage { get; set; }
        public IEnumerable<int> allPage { get; set; }
        public  IEnumerable<TEntity> listaRegistros { get; set; }
        
    }
}
