﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public int IdTipo { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluacion { get; set; }
    }
}
