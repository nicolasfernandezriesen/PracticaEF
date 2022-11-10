using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEFEscuela.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }

        [ForeignKey("Localidad")]
        public int IdLocalidad { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Calle { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Numero { get; set; }

        public List<Evaluacion> Evalaciones { get; set;}
        public Localidad Localidad { get; set; }

    }
}
