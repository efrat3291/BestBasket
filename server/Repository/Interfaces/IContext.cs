using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Chain> Chain { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInBasket> ProductInBasket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserBasket> UserBasket { get; set; }
        public void Save();
    }
}
