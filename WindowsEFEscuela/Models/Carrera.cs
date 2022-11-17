﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Carrera")]
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        public List<Planilla> Planillas { get; set; }
        public List<Plan> Planes { get; set; }
    }
}
