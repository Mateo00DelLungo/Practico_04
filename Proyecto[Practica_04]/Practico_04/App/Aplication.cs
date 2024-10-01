using Data.Domain;
using Practico_04.Services;

namespace Practico_04.App
{
    public class Aplication
    {
        public readonly ServicioManager _serviceManager;
        public readonly DetalleTurnoManager _detalleTurnoManager;
        public readonly TurnoManager _turnoManager;
        public Aplication()
        {

        }
        public static bool Validar()
        {
            return true;
        }
    }
}
