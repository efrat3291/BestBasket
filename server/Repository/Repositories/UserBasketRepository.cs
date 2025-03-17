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
    class UserBasketRepository : IRepository<UserBasket>
    {
        private readonly IContext _context;
        public UserBasketRepository(IContext context)
        {
            _context = context;
        }

        public async Task<UserBasket> AddItem(UserBasket item)
        {
            await _context.UserBasket.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.UserBasket.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<UserBasket>> GetAll()
        {
            return await _context.UserBasket.ToListAsync();
        }

        public async Task<UserBasket> GetById(int id)
        {
            return await _context.UserBasket.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserBasket> UpDateItem(int id, UserBasket item)
        {
            var userBasket = await GetById(id);
            userBasket.TotalPrice= item.TotalPrice;
            userBasket.UserId = item.UserId;
            userBasket.Date = item.Date;
            _context.Save();
            return userBasket;
        }
    }
}
