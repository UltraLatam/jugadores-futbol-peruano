using System.ComponentModel.DataAnnotations;

namespace jugadores_futbol_peruano.Models
{
    public class Player
    {
        public int Id { get; set; }

        // Propiedad Name: No puede ser nula, con una validación obligatoria
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string Name { get; set; } = string.Empty;  // Inicializada con un valor predeterminado

        // Propiedad Age: Valida que esté dentro del rango de 15 a 50
        [Range(15, 50, ErrorMessage = "Edad debe estar entre 15 y 50.")]
        public int Age { get; set; }

        // Propiedad Position: No puede ser nula, con una validación obligatoria
        [Required(ErrorMessage = "La posición es obligatoria.")]
        [StringLength(50, ErrorMessage = "La posición debe tener máximo 50 caracteres.")]
        public string Position { get; set; } = string.Empty;  // Inicializada con un valor predeterminado

        // Propiedad TeamId: Relacionada con la entidad Team, también es requerida
        [Display(Name = "Equipo")]
        [Required(ErrorMessage = "Debes seleccionar un equipo.")]
        public int? TeamId { get; set; }

        // Relación con el modelo Team: Puede ser nula si no se asigna un equipo
        public Team? Team { get; set; }

        // Constructor para inicializar propiedades de manera segura
        public Player()
        {
            Name = string.Empty;  // Asegura que Name no sea nulo
            Position = string.Empty;  // Asegura que Position no sea nulo
        }
    }
}
