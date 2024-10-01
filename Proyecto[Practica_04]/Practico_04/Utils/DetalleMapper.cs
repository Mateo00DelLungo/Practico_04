using Data.Domain;
using Practico_04.Models;

namespace Practico_04.Utils
{
    public class DetalleMapper:MapperBase<DetalleDTO, DetalleTurno>
    {
        public DetalleTurno Set(DetalleDTO dto)
        {
            return base.Set(dto);
        }
        public List<DetalleTurno> Set(List<DetalleDTO> dtolst)
        {
            return base.Set(dtolst);
        }
        public DetalleDTO Get(DetalleTurno value) 
        {
            return base.Get(value);
        }
        public List<DetalleDTO> Get(List<DetalleTurno> valuelst)
        {
            return base.Get(valuelst);
        }
    }
}
