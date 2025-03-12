using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task DeleteItem(int id);
        Task<T> UpDateItem(int id, T item);
        Task<T> AddItem(T item);
    }
}
