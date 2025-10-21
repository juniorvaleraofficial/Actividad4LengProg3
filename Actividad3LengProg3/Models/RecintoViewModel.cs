﻿using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class RecintoViewModel
    {
        [Required]
        public int Codigo { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Direccion { get; set; } = string.Empty;
    }
}
