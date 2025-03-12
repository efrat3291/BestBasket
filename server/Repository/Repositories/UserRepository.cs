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
    class UserRepository : IRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddItem(User item)
        {
            await _context.User.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.User.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> UpDateItem(int id, User item)
        {
            var user = await GetById(id);
            user.AddressId = item.AddressId;
            user.Name = item.Name;
            user.Email = item.Email;
            user.Password = item.Password;
            _context.Save();
            return user;
        }
    }
}
