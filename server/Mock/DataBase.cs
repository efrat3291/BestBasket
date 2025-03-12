using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    class DataBase : DbContext, IContext
    {
        public DbSet<Address> Address { get ; set; }
        public DbSet<Branch> Branch { get ; set ; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Chain> Chain { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInBasket> ProductInBasket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserBasket> UserBasket { get; set; }

        public void Save()
        {
            SaveChanges();
        }

    }
}
