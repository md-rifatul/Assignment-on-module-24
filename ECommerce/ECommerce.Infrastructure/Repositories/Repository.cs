using ECommerce.Infrastructure.Data;
using ECommerce.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ECommerceDbContext _db;
        private readonly DbSet<T> _set;

        public Repository(ECommerceDbContext db)
        {
            _db = db;
            _set = db.Set<T>();
        }

        public Task<List<T>> GetAllAsync() => _set.ToListAsync();
        public Task<T?> GetByIdAsync(int id) => _set.FindAsync(id).AsTask();

        public async Task AddAsync(T entity) => await _set.AddAsync(entity);
        public void Update(T entity) => _set.Update(entity);
        public void Remove(T entity) => _set.Remove(entity);

        public Task<int> SaveChangesAsync() => _db.SaveChangesAsync();
    }
}
