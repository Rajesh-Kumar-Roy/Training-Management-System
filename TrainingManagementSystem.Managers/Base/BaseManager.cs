using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers.Base
{
    public class BaseManager<T>:IBaseManager<T> where T:class
    {
        private readonly IRepository<T> _repository;
        public BaseManager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
