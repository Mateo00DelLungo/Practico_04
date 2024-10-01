using Practico_04.Interfaces;
using Practico_04.Models;

namespace Practico_04.Services
{
    public class DetalleManager : IManager<DetalleDTO>
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetalleDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DetalleDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save(DetalleDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DetalleDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
