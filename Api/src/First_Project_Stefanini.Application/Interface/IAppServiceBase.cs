using First_Project_Stefanini.Application.DTO;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.Interface
{
    public interface IAppServiceBase<TEntity, TEntityRequest,TEntityResponse>
        where TEntity : EntityBase
        where TEntityRequest : EntidadeRequestBase
        where TEntityResponse : EntidadeResponseBase
    {
        TEntityResponse Add(TEntityRequest entidadeRequest);
        public IEnumerable<TEntityResponse> getAll();
        //TEntityResponse Remove(TEntityRequest entidadeRequest);
        //TEntityResponse RemoveById(int id);
        //TEntityResponse SearchByID(int id);
        //TEntityResponse Update(TEntityRequest entidadeRequest);
        // TEntityResponse UpdateById(int id);
    }
}
