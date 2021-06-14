using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UsuarioEntity
    {
        [Key]
        [Required]
        public string UsuarioId { get; set; }

        [Required]
        public string UsuarioAcceso { get; set; }

        [Required]
        public string TrabajadorId { get; set; }
        public TrabajadorEntity Trabajador { get; set; }
    }
}
