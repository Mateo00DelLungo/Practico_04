using Data.Domain;
using Practico_04.Interfaces;
using Practico_04.Models;
using Practico_04.Services;

namespace Practico_04.App
{
    public class Aplication
    {
        public readonly IManager<ServicioDTO> _serviceManager;
        public readonly IManager<DetalleDTO> _detalleManager;
        public readonly IManager<TurnoDTO> _turnoManager;
        public Aplication(IManager<ServicioDTO> serviceManager,
            IManager<DetalleDTO> detalleManager, IManager<TurnoDTO> turnoManager)
        {
            _serviceManager = serviceManager;
            _detalleManager = detalleManager;
            _turnoManager = turnoManager;
        }
    }
}
