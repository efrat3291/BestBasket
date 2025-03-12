using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public static class ExtentionRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Address>, AddressRepository>();
            services.AddScoped<IRepository<Branch>, BranchRepository>();
            services.AddScoped<IRepository<Category>, CategoryRepository>();
            services.AddScoped<IRepository<Chain>, ChainRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<ProductInBasket>, ProductInBasketRepository>();
            services.AddScoped<IRepository<UserBasket>, UserBasketRepository>();
            services.AddScoped<IRepository<User>, UserRepository>();
            return services;

        }
    }
}
