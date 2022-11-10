using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEFEscuela.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }

        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }

        [ForeignKey("Materia")]
        public int IdMateria { get; set; }

        [ForeignKey("Profesor")]
        public int IdProfesor { get; set; }

        [ForeignKey("Curso")]
        public int IdCurso { get; set; }
        public DateTime Fecha { get; set; }
        public Curso Curso { get; set; }
        public Profesor Profesor { get; set; }
        public Materia Materia { get; set; }
        public Carrera Carrera { get; set; }
        public List<Detalle> Detalles { get; set; }
    }
}
