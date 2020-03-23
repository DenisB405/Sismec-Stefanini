using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.Domain.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : EntityBase
    {
        private readonly IRepository<TEntity> _IRepository;

        public Service(IRepository<TEntity> iRepository)
        {
            _IRepository = iRepository;
        }

        public virtual TEntity Add(TEntity entity)
        {
            if (entity == null)
                return null;
            return _IRepository.Add(entity);
        }

        public IEnumerable<TEntity> getAll()
        {
            return _IRepository.GetAll();
        }
    }
}
