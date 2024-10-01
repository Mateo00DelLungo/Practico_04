using Data.Domain;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class DetalleRepository : IRepository<DetalleTurno>
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetalleTurno>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DetalleTurno> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save(DetalleTurno obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DetalleTurno obj)
        {
            throw new NotImplementedException();
        }
    }
}
