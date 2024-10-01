﻿using Data.Domain;
using Humanizer;
using Newtonsoft.Json.Linq;
using Practico_04.Models;

namespace Practico_04.Utils
{
    public class TurnoMapper:MapperBase<TurnoDTO,Turno>
    {
        public Turno Set(TurnoDTO dto)
        {
            if (dto == null) { return null; }
            return base.Set(dto);
        }
        public List<Turno> Set(List<TurnoDTO> dtolst)
        {
            if (dtolst == null || dtolst.Count == 0) { return null; }
            return base.Set(dtolst);
        }
        public TurnoDTO Get(Turno value)
        {
            if(value == null) { return null; }
            return base.Get(value);
        }
        public List<TurnoDTO> Get(List<Turno> valuelst)
        {
            if (valuelst == null || valuelst.Count == 0) { return null; }
            return base.Get(valuelst);
        }
    }
}
