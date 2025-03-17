using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserService:IService<User>
    {
        string Generate(string userName, string password);
        Task<User> Authenticate(User u);

    }
}
