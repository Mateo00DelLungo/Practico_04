using Data.Domain;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ServicioRepository : IRepository<Servicio>
    {
        private readonly TurnoDbContext _context;
        public ServicioRepository(TurnoDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(int id)
        {
            var delete = _context.Servicio.Find(id);
            _context.Servicio.Remove(delete);
            return 1 == await _context.SaveChangesAsync();
        }

        public async Task<List<Servicio>> GetAll()
        {
            return await _context.Servicio.ToListAsync();
        }

        public async Task<Servicio> GetById(int id)
        {
            return await _context.Servicio.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> Save(Servicio value)
        {
            _context.Servicio.Add(value);
            return 1 == await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(Servicio updated)
        {
            var current = _context.Servicio.FirstOrDefault(p => p.Id == updated.Id);
            current.Nombre = updated.Nombre;
            current.Costo = updated.Costo;
            current.enPromocion = updated.enPromocion;
            return 1 == await _context.SaveChangesAsync();
        }
    }
}
