using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }

        [ForeignKey("Tipo")]
        public int? IdTipo { get; set; }

        [ForeignKey("Estudiante")]
        public int? IdEstudiante { get; set; }

        [ForeignKey("Detalle")]
        public int? IdDetalle { get; set; }

        [Column(TypeName = "decimal")]
        public Decimal? Nota { get; set; }
        public Tipo Tipo { get; set; }
        public Estudiante Estudiante { get; set; }
        public Detalle Detalle { get; set; }

    }
}
