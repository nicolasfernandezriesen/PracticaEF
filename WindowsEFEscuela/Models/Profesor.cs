﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }

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
        public Localidad Localidad { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
