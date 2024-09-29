using Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IServicioRepository
    {
        bool Save(Servicio value);
        bool Delete(int id);
        List<Servicio> GetAll();
        Servicio GetById(int id);
    }
}
