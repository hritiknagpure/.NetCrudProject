using BlogApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Data
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
