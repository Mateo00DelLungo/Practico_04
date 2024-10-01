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
        internal int ServicioId { get; set; }
        internal Servicio Servicio { get; set; }

        //relacion
        internal int TurnoId { get; set; }
        internal Turno Turno { get; set; }
    }
}
