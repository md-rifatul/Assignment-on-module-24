using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repo;

        public CategoryService(IRepository<Category> repo)
        {
            _repo = repo;
        }

        public Task<List<Category>> GetAllAsync() => _repo.GetAllAsync();

        public Task<Category?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task CreateAsync(Category category)
        {
            await _repo.AddAsync(category);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _repo.Update(category);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing is null) return;

            _repo.Remove(existing);
            await _repo.SaveChangesAsync();
        }
    }
}

