using ECommerce.Domain.Entities;
using ECommerce.Application.Interfaces;
using ECommerce.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repo;

        public ProductService(IRepository<Product> repo)
        {
            _repo = repo;
        }

        public Task<List<Product>> GetAllAsync() => _repo.GetAllAsync();
        public Task<Product?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public async Task CreateAsync(Product product)
        {
            await _repo.AddAsync(product);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _repo.Update(product);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _repo.GetByIdAsync(id);
            if (item is null) return;

            _repo.Remove(item);
            await _repo.SaveChangesAsync();
        }
    }
}
