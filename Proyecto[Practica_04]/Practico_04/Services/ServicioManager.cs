using Data;
using Data.Domain;
using Data.Interfaces;
using Data.Repositories;
using Humanizer;
using Practico_04.Interfaces;
using Practico_04.Models;

namespace Practico_04.Services
{
    public class ServicioManager : IManager<ServicioDTO>
    {
        private readonly IRepository<Servicio> _repository;
        private readonly IMapper<ServicioDTO,Servicio> _mapper;
        public ServicioManager(IRepository<Servicio> repository,
            IMapper<ServicioDTO,Servicio> mapeador)
        {
            _repository = repository;
            _mapper = mapeador;
        }
        public async Task<bool> Save(ServicioDTO dto)
        {
            var value = _mapper.Set(dto);
            return await _repository.Save(value);
        }
        public async Task<bool> Delete(int id)
        {
            if (null == await GetById(id)) { return false; }
            return await _repository.Delete(id);
        }
        public async Task<List<ServicioDTO>> GetAll()
        {
            return _mapper.Get(await _repository.GetAll());
        }
        public async Task<ServicioDTO> GetById(int id)
        {
            return _mapper.Get(await _repository.GetById(id));
        }
        public async Task<bool> Update(ServicioDTO dto)
        {
            if(null == await GetById(dto.Id)) { return false; }
            var value = _mapper.Set(dto);
            return await _repository.Update(value);
        }
    }
}
