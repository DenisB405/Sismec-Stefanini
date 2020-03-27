
using First_Project_Stefanini.Application.DTO;
using First_Project_Stefanini.Application.DTO.Paginacao;
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
           
            response.quantidadeTotal = allRegistro.Count;

            response.totalPages = response.quantidadeTotal / request.quantidade;
            response.currentPage = request.page;
            if (request.quantidade % request.quantidade != 0)
                response.totalPages++;

                response.listaRegistros = allRegistro.Skip(paginaSkip).Take(request.quantidade);
            return response;
        }
    }
}
