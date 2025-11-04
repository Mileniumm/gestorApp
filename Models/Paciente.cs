using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace gestorApp.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Configura Id como clave primaria y autoincremental
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Apellido { get; set; } = string.Empty;
        [Required]
        public int Edad { get; set; } = 0;
        [Required]
        public string FechaNacimiento { get; set; } = string.Empty;
        [Required]
        public string TipoDocumento { get; set; } = string.Empty;
        [Required]
        public string NumeroDocumento { get; set; } = string.Empty;
        [Required]
        public string Telefono { get; set; } = string.Empty;
        [Required]
        public string CoberturaMedica { get; set; } = string.Empty;
    }
}