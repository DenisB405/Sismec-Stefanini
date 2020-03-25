using First_Project_Stefanini.Application.DTO.Instituicao;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.Interface
{
    public interface IInstituicaoAppService : IAppServiceBase<Instituicao,InstituicaoRequest, InstituicaoResponse>
    {
        InstituicaoResponse SearchByCodigo(int codigo);
        InstituicaoResponse UpdateByCodigo(InstituicaoRequest instituicao);
        InstituicaoResponse DeleteByCodigo(int Codigo);
    }
}
