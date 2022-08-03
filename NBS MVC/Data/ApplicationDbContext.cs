using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NBS_MVC.Models;

namespace NBS_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<customer> customers { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
               
        }
    }
}