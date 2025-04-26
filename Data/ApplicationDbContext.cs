using Microsoft.EntityFrameworkCore;
using jugadores_futbol_peruano.Models;

namespace jugadores_futbol_peruano.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Definimos las tablas
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
    }
}
