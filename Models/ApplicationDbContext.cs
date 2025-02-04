using Microsoft.EntityFrameworkCore;

namespace WebFormContact.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Contacto> ContactMessages { get; set; }
    }
}
