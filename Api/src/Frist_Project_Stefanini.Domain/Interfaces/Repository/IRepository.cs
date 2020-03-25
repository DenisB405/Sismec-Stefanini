using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Frist_Project_Stefanini.ApplicarionCore.Interfaces
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {

        TEntity Add(TEntity entity);
        TEntity SearchById(int id);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Delete(TEntity entity);

    }
}
