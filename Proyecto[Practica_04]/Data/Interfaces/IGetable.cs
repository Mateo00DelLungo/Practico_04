using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGetable<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
