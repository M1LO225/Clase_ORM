using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Proyecto_BD.Models
{
    public class EstudianteUdla
    {
        [Key]
        public int IdBanner { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [EmailAddress]
        [AllowNull]
        public string Correo { get; set; }
        public bool TieneBeca { get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }

    }
}
