using Data.Domain;
using Data.Interfaces;
using Humanizer;
using Newtonsoft.Json.Linq;
using Practico_04.Models;


namespace Practico_04.Utils
{
    public class ServicioMapper : MapperBase<ServicioDTO, Servicio>
    {
        //SERVICIO
        public Servicio Set(ServicioDTO dto)
        {
            if(dto == null) return null;
            return base.Set(dto);
        }
        /* 
        var value = new Servicio()
        {
            Id = entity.Id,
            Nombre = entity.Nombre,
            Costo = entity.Costo,
            enPromocion = entity.enPromocion
        };
        */
        public List<Servicio> Set(List<ServicioDTO> dtolst)
        {
            if (dtolst == null || dtolst.Count == 0) return null;
            return base.Set(dtolst);
        }
        public ServicioDTO Get(Servicio value)
        {
            if(value == null) return null;
            return base.Get(value);
        }
        public List<ServicioDTO> Get(List<Servicio> valuelst)
        {
            if (valuelst == null || valuelst.Count == 0) return null;
            return base.Get(valuelst);
        }
    }
}
