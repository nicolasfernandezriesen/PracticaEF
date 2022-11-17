﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
