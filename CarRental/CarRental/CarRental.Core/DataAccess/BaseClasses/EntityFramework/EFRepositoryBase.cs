using CarRental.Core.DataAccess.IBaseRepositories;
using CarRental.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace CarRental.Core.DataAccess.BaseClasses.EntityFramework {
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new() {

        protected TContext context;
        public EFRepositoryBase() {
            context = EFContextGenerator<TContext>.GetContextInstance();
        }

        public void Add(TEntity entity) {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity) {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity) {

            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] include) {
            return context.Set<TEntity>().Where(filter).MyInclude(include).SingleOrDefault();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include) {

            return filter == null
                ? context.Set<TEntity>().MyInclude(include).ToList()
                : context.Set<TEntity>().Where(filter).MyInclude(include).ToList();
        }

    }
}
