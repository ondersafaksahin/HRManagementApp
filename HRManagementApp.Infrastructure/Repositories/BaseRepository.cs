using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.IRepositories;
using HRManagementApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class,IBaseEntity
    {
        private readonly HRDBContext _database;
        protected DbSet<T> _table;

        public BaseRepository(HRDBContext database)
        {
            _database = database;
            _table = _database.Set<T>();
        }

        public async Task Add(T item)
        {
            await _table.AddAsync(item);
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _table.AnyAsync(expression);
        }

        public async Task Delete(T item)
        {
            _database.Entry<T>(item).State = EntityState.Deleted;
            item.Status = Domain.Enums.Status.Deleted;
            await Update(item);
        }

        public async Task<List<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return await _table.Where(expression).FirstAsync();

        }

        public async Task<List<T>> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await _table.Where(expression).ToListAsync();
        }

        public async Task Update(T item)
        {
            _database.Entry<T>(item).State = EntityState.Modified;
            await Save();
        }

        public async Task<int> Save()
        {
            return await _database.SaveChangesAsync();
        }
    }
}
