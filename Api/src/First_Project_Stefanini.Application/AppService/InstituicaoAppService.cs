using AutoMapper;
using First_Project_Stefanini.Application.DTO.Instituicao;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services;
using Frist_Project_Stefanini.Domain.Interfaces.Services;

namespace First_Project_Stefanini.Application.AppService
{
    public class InstituicaoAppService : AppServiceBase<
        Instituicao,
        InstituicaoRequest,
        InstituicaoResponse>, IInstituicaoAppService
    {
        protected readonly IInstituicaoService servicoInstituicao;
        public InstituicaoAppService(IInstituicaoService servico, IMapper iMapper) : base(servico, iMapper)
        {
            servicoInstituicao = servico;
        }

        public InstituicaoResponse DeleteByCodigo(int Codigo)
        {
            throw new System.NotImplementedException();
        }

        public InstituicaoResponse SearchByCodigo(int codigo)
        {
            var Entity = servicoInstituicao.SearchByCodigo(codigo);

            return iMapper.Map<InstituicaoResponse>(Entity);
        }

        public InstituicaoResponse UpdateByCodigo(InstituicaoRequest request)
        {
            var convert = iMapper.Map<Instituicao>(request);
            var Entity = servico.Update(convert);

            return iMapper.Map<InstituicaoResponse>(Entity);
        }
    }
}
