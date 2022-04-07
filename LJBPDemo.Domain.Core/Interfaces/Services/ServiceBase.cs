using LJBPDemo.Domain.Core.Interfaces.Repository;
using System.Collections.Generic;

namespace LJBPDemo.Domain.Core.Interfaces.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}