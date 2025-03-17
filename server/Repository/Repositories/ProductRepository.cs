using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    class ProductRepository : IRepository<Product>
    {
        private readonly IContext _context;
        public ProductRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Product> AddItem(Product item)
        {
            await _context.ProductInBasket.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.Product.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Product.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> UpDateItem(int id, Product item)
        {
            var product = await GetById(id);
            product.Name = item.Name;
            product.Category = item.Category;
            product.SecondaryName = item.SecondaryName;
            _context.Save();
            return product;
        }
    }
}
