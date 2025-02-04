using Microsoft.EntityFrameworkCore;

namespace WebFormContact.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contacto> Contacto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Contacto>().HasKey(r => r.IdContacto);
        }
    }
}
