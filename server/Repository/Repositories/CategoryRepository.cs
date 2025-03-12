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
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext _context;
        public CategoryRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Category> AddItem(Category item)
        {
            await _context.Category.AddAsync(item);
            _context.Save();
            return item;
        }

        public async Task DeleteItem(int id)
        {
            _context.Branch.Remove(await GetById(id));
            _context.Save();
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _context.Category.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Category> UpDateItem(int id, Category item)
        {
            var category = await GetById(id);
            category.Name = item.Name;
            _context.Save();
            return category;
        }
    }
}
