using AutoMapper;
using First_Project_Stefanini.Application.DTO;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.AppService
{
    public class AppServiceBase<TEntity, TEntityRequest, TEntityResponse> :
        IAppServiceBase<TEntity, TEntityRequest, TEntityResponse>
        where TEntity : EntityBase
        where TEntityRequest : EntidadeRequestBase
        where TEntityResponse : EntidadeResponseBase
    {
        protected readonly IService<TEntity> servico;
        protected readonly IMapper iMapper;

        public AppServiceBase(IService<TEntity> servico, IMapper iMapper)
        {
            this.servico = servico;
            this.iMapper = iMapper;
        }

        public TEntityResponse Add(TEntityRequest entidadeRequest)
        {
            var convert = iMapper.Map<TEntity>(entidadeRequest);
            var Entity = servico.Add(convert);
            
            return iMapper.Map<TEntityResponse>(Entity);
        }
    }
}
