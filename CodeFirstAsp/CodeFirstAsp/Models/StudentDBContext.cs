using Microsoft.EntityFrameworkCore;

namespace CodeFirstAsp.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
            // Constructor body, if needed 
        }

        public DbSet<Student> Students { get; set; }
    }
}
