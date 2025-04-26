using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jugadores_futbol_peruano.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; } // Clave primaria

        [ForeignKey("Player")]
        public int PlayerId { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }

        public required Player Player { get; set; } // Relación obligatoria con Player
        public required Team Team { get; set; }     // Relación obligatoria con Team
    }
}
