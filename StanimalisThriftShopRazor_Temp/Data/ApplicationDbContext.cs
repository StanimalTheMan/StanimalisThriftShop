using Microsoft.EntityFrameworkCore;
using StanimalisThriftShopRazor_Temp.Models;

namespace StanimalisThriftShopRazor_Temp.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

	public DbSet<Category> Categories { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>().HasData(
			new Category { Id = 1, Name = "Jerseys", DisplayOrder = 1},
			new Category { Id = 2, Name = "Caps", DisplayOrder = 2 },
			new Category { Id = 3, Name = "Collectibles", DisplayOrder = 3 }
		);
	}

}
