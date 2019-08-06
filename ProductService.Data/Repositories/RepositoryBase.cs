using Microsoft.EntityFrameworkCore;
using ProductService.Data.Context;
using ProductService.Domain.Entities;
using ProductService.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductService.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly DataContext _context;

        public RepositoryBase(DataContext context){
            _context = context;
        }
        public TEntity Get(int id){
            return _context.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<TEntity> GetAll(){
            return _context.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().ToList();
        }

        public void Save(TEntity entity){
            _context.Add(entity);            
        }

        public void Update(TEntity entity){
            _context.Entry(entity).State = EntityState.Modified;            
        }

        public void Delete(TEntity entity){
            _context.Entry(entity).State = EntityState.Deleted;
            _context.Remove(entity);
        }

        public int Commit(){
            return _context.SaveChanges();
        }     
    }

}
