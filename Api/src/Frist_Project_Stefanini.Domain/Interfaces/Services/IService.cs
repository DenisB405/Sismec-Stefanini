using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : EntityBase
    {
        TEntity Add(TEntity entity);
        public IEnumerable<TEntity> getAll();
        TEntity SearchById(int id);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Delete(TEntity entity);

    }
}
