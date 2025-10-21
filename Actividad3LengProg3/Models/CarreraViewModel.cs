﻿using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class CarreraViewModel
    {
        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public int CantidadCreditos { get; set; }

        [Required]
        public int CantidadMaterias { get; set; }
    }
}