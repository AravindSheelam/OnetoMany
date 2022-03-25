using Microsoft.EntityFrameworkCore;

namespace OtmCore.Models
{
    public class InstituteContext : DbContext
    {
        public InstituteContext(DbContextOptions options)
            :base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<College> Colleges { get; set; }
    }
}
