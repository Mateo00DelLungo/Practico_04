using Data.Domain;
using Data.Interfaces;
using Practico_04.Models;

namespace Practico_04.Services
{
    public static class Mapper
    {
        //SERVICIO
        public static ServicioDTO GetServicio(Servicio value)
        {
            var dto = new ServicioDTO()
            {
                Id = value.Id,
                Nombre = value.Nombre,
                Costo = value.Costo,
                enPromocion = value.enPromocion
            };
            return dto;
        }
        public static List<ServicioDTO> GetServicio(List<Servicio> values)
        {
            var lst = new List<ServicioDTO>();
            foreach (Servicio x in values)
            {
                lst.Add(GetServicio(x));
            }
            return lst;
        }
        public static Servicio SetServicio(ServicioDTO dto)
        {
            var value = new Servicio()
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Costo = dto.Costo,
                enPromocion = dto.enPromocion
            };
            return value;
        }
        public static List<Servicio> SetServicio(List<ServicioDTO> dtos)
        {
            var lst = new List<Servicio>();
            foreach (ServicioDTO x in dtos)
            {
                lst.Add(SetServicio(x));
            }
            return lst;
        }

        //DETALLE
        public static DetalleDTO GetDetalle(DetalleTurno value)
        {
            var dto = new DetalleDTO()
            {
                Id = value.Id,
                Observaciones = value.Observaciones
            };
            return dto;
        }
        public static List<DetalleDTO> GetDetalle(List<DetalleTurno> values)
        {
            var lst = new List<DetalleDTO>();
            foreach (DetalleTurno x in values)
            {
                lst.Add(GetDetalle(x));
            }
            return lst;
        }
        public static DetalleTurno SetDetalle(DetalleDTO dto)
        {
            var value = new DetalleTurno()
            {
                Id = dto.Id,
                Observaciones = dto.Observaciones
            };
            return value;
        }
        public static List<DetalleTurno> SetDetalle(List<DetalleDTO> dtos)
        {
            var lst = new List<DetalleTurno>();
            foreach (DetalleDTO x in dtos)
            {
                lst.Add(SetDetalle(x));
            }
            return lst;
        }

        //TURNO
        public static TurnoDTO GetTurno(Turno value)
        {
            var dto = new TurnoDTO()
            {
                Id = value.Id,
                Fecha = value.Fecha,
                Hora = value.Hora,
                Cliente = value.Cliente
            };
            return dto;
        }
        public static List<TurnoDTO> GetTurno(List<Turno> values)
        {
            var lst = new List<TurnoDTO>();
            foreach (Turno x in values)
            {
                lst.Add(GetTurno(x));
            }
            return lst;
        }
        public static Turno SetTurno(TurnoDTO dto)
        {
            var value = new Turno()
            {
                Id = dto.Id,
                Fecha = dto.Fecha,
                Hora = dto.Hora,
                Cliente = dto.Cliente
            };
            return value;
        }
        public static List<Turno> SetTurno(List<TurnoDTO> dtos)
        {
            var lst = new List<Turno>();
            foreach (TurnoDTO x in dtos)
            {
                lst.Add(SetTurno(x));
            }
            return lst;
        }

    }
}
