using Practico_04.Interfaces;

namespace Practico_04.Models
{
    public class TurnoDTO : IDataTransferObject
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Cliente { get; set; }
        public TurnoDTO()
        {
            Fecha = DateTime.Now.AddDays(1);
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
