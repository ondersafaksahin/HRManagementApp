using HRManagementApp.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.IRepositories
{
    public interface IBaseRepository<T> where T:IBaseEntity
    {
        public Task Add(T item);
        public Task Update(T item);
        public Task Delete(T item);
        public Task<T> GetBy(Expression<Func<T,bool>> expression);
        public Task<List<T>> GetDefault(Expression<Func<T, bool>> expression);
        public Task<List<T>> GetAll();
        public Task<bool> Any(Expression<Func<T, bool>> expression);
        public Task<int> Save();

    }
}
