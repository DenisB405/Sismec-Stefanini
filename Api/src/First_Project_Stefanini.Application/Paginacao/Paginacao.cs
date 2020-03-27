

using First_Project_Stefanini.Application.DTO;
using First_Project_Stefanini.Application.DTO.Paginacao;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace First_Project_Stefanini.Application.Paginacao
{
    public class Paginacao<TEntityResponse> where TEntityResponse : EntidadeResponseBase
    {
        public static PaginacaoResponse<TEntityResponse> getPage(List<TEntityResponse> allRegistro, PaginacaoRequest request)
        {
            var paginaSkip = (request.page-1) * request.quantidade;
            
            PaginacaoResponse<TEntityResponse> response = new PaginacaoResponse<TEntityResponse>();
            List<int> allpages = new List<int>();
            
      
            response.quantPage = (allRegistro.Count-1) * request.quantidade;
            response.quantidade = allRegistro.Count;
            
            response.currentPage = request.page;
            if (request.quantidade % (allpages.Count()) != 0)
                response.quantPage++;

                response.listaRegistros = allRegistro.Skip(paginaSkip).Take(request.quantidade);
            return response;
        }
    }
}
