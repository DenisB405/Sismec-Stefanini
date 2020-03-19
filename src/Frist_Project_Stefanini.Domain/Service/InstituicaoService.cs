using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces;
using Frist_Project_Stefanini.Domain.Service;

namespace Frist_Project_Stefanini.ApplicarionCore.Service
{
    public class InstituicaoService : Service<Instituicao>, IInstituicaoService
    {
        private readonly IInstituicaoRepository instituicaoRepository;
        public InstituicaoService(IInstituicaoRepository iRepository) : base(iRepository)
        {
            instituicaoRepository = iRepository;
        }
        public override Instituicao Add(Instituicao entity)
        {
            if (entity == null)
                return null;
            if (instituicaoRepository.SearchByCodigo(entity.Codigo) != null)
                return null;
            if (entity.Codigo <= 0 || entity.Codigo > 99999)
                return null;
            

            return instituicaoRepository.Add(entity);
        }
    }
}
