using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_BD.Models
{
    public class EstudianteUdla
    {
        [Key]
        public int IdBanner { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public bool TieneBeca { get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }

    }
}
