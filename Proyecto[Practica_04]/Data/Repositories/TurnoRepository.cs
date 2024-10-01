using Data.Domain;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TurnoRepository : IRepository<Turno>
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Turno>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Turno> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save(Turno obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Turno obj)
        {
            throw new NotImplementedException();
        }
    }
}
