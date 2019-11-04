using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagementSystem.Managers.Contracts
{
    public interface IBaseManager<T> where T:class
    {
        bool Add(T entity);
        bool Remove(T entity);
        bool Update(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
