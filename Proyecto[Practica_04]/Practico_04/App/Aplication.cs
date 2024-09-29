using Data.Domain;
using Practico_04.Services;

namespace Practico_04.App
{
    public class App
    {
        private readonly ServicioManager _serviceManager;
        public bool Save<T>(T value)
        {
            switch (value)
            {
                case value.GetType() == Servicio:
                        return _serviceManager.Save(value);
            }
        };
    }
}
