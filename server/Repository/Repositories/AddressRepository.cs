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
    class AddressRepository : IRepository<Address>
    {
        private readonly IContext _context;
        public AddressRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Address> AddItem(Address item)
        {
            await _context.Address.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.Address.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<Address>> GetAll()
        {
            return await _context.Address.ToListAsync();
        }

        public async Task<Address> GetById(int id)
        {
            return await _context.Address.FirstOrDefaultAsync(x => x.Id==id);
        }

        public async Task<Address> UpDateItem(int id, Address item)
        {
            var address = await GetById(id);
            address.City = item.City;
            address.Name = item.Name;
            address.X = item.X;
            address.Y = item.Y;
            _context.Save();
            return address;
        }
    }
}
