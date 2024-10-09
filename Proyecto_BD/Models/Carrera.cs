using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
