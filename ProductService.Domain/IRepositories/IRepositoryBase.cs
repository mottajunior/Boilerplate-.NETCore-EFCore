using ProductService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Domain.IRepositories
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        int Commit();

        void Delete(TEntity entity);
        
    }
}
