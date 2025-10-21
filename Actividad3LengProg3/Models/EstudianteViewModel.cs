using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class EstudianteViewModel : IValidatableObject
    {
        // Nombre completo
        [Required(ErrorMessage = "El campo 'Nombre completo' es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo {1} caracteres.")]
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; }= string.Empty;

        // Matrícula
        [Required(ErrorMessage = "La matrícula es obligatoria.")]
        [StringLength(15, MinimumLength = 6,
            ErrorMessage = "La matrícula debe tener entre {2} y {1} caracteres.")]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; } = string.Empty;

        // Carrera (lista)
        [Required(ErrorMessage = "Seleccione una carrera.")]
        [Display(Name = "Carrera")]
        public string Carrera { get; set; }=string.Empty;

        // Recinto (lista)
        [Required(ErrorMessage = "Seleccione un recinto.")]
        [Display(Name = "Recinto")]
        public string Recinto { get; set; } = string.Empty;

        // Correo institucional
        [Required(ErrorMessage = "El correo institucional es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        [Display(Name = "Correo institucional")]
        public string CorreoInstitucional { get; set; } =string.Empty;

        // Celular
        [Phone(ErrorMessage = "Número de celular inválido.")]
        [MinLength(10, ErrorMessage = "El celular debe tener al menos {1} dígitos.")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        // Teléfono
        [Phone(ErrorMessage = "Número de teléfono inválido.")]
        [MinLength(10, ErrorMessage = "El teléfono debe tener al menos {1} dígitos.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        // Dirección
        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(200, ErrorMessage = "Máximo {1} caracteres.")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        // Fecha de nacimiento
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        // Género (lista)
        [Required(ErrorMessage = "Seleccione un género.")]
        [Display(Name = "Género")]
        public string Genero { get; set; }

        // Turno (lista)
        [Required(ErrorMessage = "Seleccione un turno.")]
        [Display(Name = "Turno")]
        public string Turno { get; set; }

        // Beca
        [Display(Name = "¿Está becado?")]
        public bool EstaBecado { get; set; }

        // Porcentaje de beca (0-100). Solo válido si EstaBecado = true.
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre {1} y {2}.")]
        [Display(Name = "Porcentaje de beca")]
        public int? PorcentajeBeca { get; set; }

        // Validación condicional para la beca
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EstaBecado && (PorcentajeBeca == null))
            {
                yield return new ValidationResult(
                    "Indique el porcentaje de beca.",
                    new[] { nameof(PorcentajeBeca) });
            }
        }
    }
}

