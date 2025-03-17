using Repository.Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    class UserService : IUserService
    {
        public Task<User> AddItem(User item)
        {
            throw new NotImplementedException();
        }

        public Task<User> Authenticate(User u)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public string Generate(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpDateItem(int id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
