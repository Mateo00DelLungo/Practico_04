using Data.Domain;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly TurnoDbContext _context;
        public ServicioRepository(TurnoDbContext context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Servicio> GetAll()
        {
            return _context.Servicio.ToList();
        }

        public Servicio GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Servicio value)
        {
            throw new NotImplementedException();
        }
    }
}
