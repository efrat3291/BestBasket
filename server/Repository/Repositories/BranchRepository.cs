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
    class BranchRepository : IRepository<Branch>
    {
        private readonly IContext _context;
        public BranchRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Branch> AddItem(Branch item)
        {
            await _context.Branch.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.Branch.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<Branch>> GetAll()
        {
            return await _context.Branch.ToListAsync();
        }

        public async Task<Branch> GetById(int id)
        {
            return await _context.Branch.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Branch> UpDateItem(int id, Branch item)
        {
            var branch = await GetById(id);
            branch.Name = item.Name;
            branch.Address = item.Address;
            branch.Chain = item.Chain;
            branch.ChainId = item.ChainId;
            branch.AddressId = item.AddressId;
            _context.Save();
            return branch;
        }
    }
}
