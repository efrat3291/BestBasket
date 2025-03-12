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
    class ChainRepository : IRepository<Chain>
    {
        private readonly IContext _context;
        public ChainRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Chain> AddItem(Chain item)
        {
            await _context.Chain.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.Chain.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<Chain>> GetAll()
        {
            return await _context.Chain.ToListAsync();
        }

        public async Task<Chain> GetById(int id)
        {
            return await _context.Chain.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Chain> UpDateItem(int id, Chain item)
        {
            var chain = await GetById(id);
            chain.Name = item.Name;
            _context.Save();
            return chain;
        }
    }
}
