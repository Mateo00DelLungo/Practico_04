using Data;
using Data.Domain;
using Data.Interfaces;
using Data.Repositories;
using Practico_04.Models;

namespace Practico_04.Services
{
    public class ServicioManager
    {

        private readonly IServicioRepository _repository;
        public ServicioManager(TurnoDbContext context)
        {
            _repository = new ServicioRepository(context);
        }
        public bool Save(ServicioDTO dto)
        {
            return _repository.Save();
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
        public List<ServicioDTO> GetAll()
        {
            return Mapper.GetServicio(_repository.GetAll());
        }
        public ServicioDTO GetById(int id)
        {
            return Mapper.GetServicio(_repository.GetById(id));
        }
        public bool Update(ServicioDTO dto)
        {
            return _
        }
    }
}
