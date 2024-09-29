using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain
{
    public class DetalleTurno
    {
        //[Key]
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Observaciones { get; set; }

        //relacion
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        //relacion
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }
    }
}
