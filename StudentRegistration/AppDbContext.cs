using Microsoft.EntityFrameworkCore;
using StudentRegistration.Models;

namespace StudentRegistration { 

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Student> students { get; set; }
} 
}
