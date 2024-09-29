namespace Practico_04.Models
{
    public class TurnoDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Cliente { get; set; }
        public TurnoDTO()
        {
            Fecha = DateTime.Now.AddDays(1);
        }
    }
}
