using Microsoft.EntityFrameworkCore;
using StanimalisThriftShop.Models;

namespace StanimalisThriftShop.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}
