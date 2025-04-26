using System.Collections.Generic;

namespace jugadores_futbol_peruano.Models
{
    public class Team
    {
        public int Id { get; set; } // Llave primaria

        public string Name { get; set; }

        public List<Player> Players { get; set; } // Relación 1:N con jugadores
    }
}
