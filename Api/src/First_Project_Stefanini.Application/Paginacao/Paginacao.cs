

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
            response.quantidade = allRegistro.Count;
            response.listaRegistros = allRegistro.Skip(paginaSkip).Take(request.quantidade);
            return response;
        }
    }
}
