using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }
        
        [ForeignKey("Planilla")]
        public int IdPlanilla { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public Planilla Planilla { get; set; }
        public Estado Estado { get; set; }
    }
}
