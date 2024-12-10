using JWTImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTImplementation.Context
{
    public class JwtContext: DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options): base(options)
        {

            
        }
        public DbSet<User> users { get; set; }
        public DbSet<Employe> employe { get; set; }
        public object Employees { get; internal set; }
    }
}
