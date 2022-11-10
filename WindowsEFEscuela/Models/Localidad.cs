using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Localidad")]
    public class Localidad
    {
        [Key]
        public int IdLocalidad { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        public string Nombre { get; set; }

        public List<Estudiante> Estudantes { get; set; }
        public List<Profesor> Profesores { get; set; }
    }
}
