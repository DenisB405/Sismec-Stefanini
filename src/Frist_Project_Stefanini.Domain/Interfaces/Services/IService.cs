using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : EntityBase
    {
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> getAll();
        //TEntity Remove(TEntity entity);
        //TEntity RemoveById(int id);
        //TEntity SearchByID(int id);
        //TEntity Update(TEntity entity);
        //TEntity UpdateById(int id);
    }
}
