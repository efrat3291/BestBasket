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
    class ProductInBasketRepository : IRepository<ProductInBasket>
    {
        private readonly IContext _context;
        public ProductInBasketRepository(IContext context)
        {
            _context = context;
        }

        public async Task<ProductInBasket> AddItem(ProductInBasket item)
        {
            await _context.ProductInBasket.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.ProductInBasket.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<ProductInBasket>> GetAll()
        {
            return await _context.ProductInBasket.ToListAsync();
        }

        public async Task<ProductInBasket> GetById(int id)
        {
            return await _context.ProductInBasket.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ProductInBasket> UpDateItem(int id, ProductInBasket item)
        {
            var productInBasket = await GetById(id);
            productInBasket.BasketId = item.BasketId;
            productInBasket.Amount = item.Amount;
            _context.Save();
            return productInBasket;
        }
    }
}
