
using CorePronia.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessPronia.Contexts;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
	{
	}
	public DbSet<SlideItem> SlideItems { get; set; } = null!;
	public DbSet<ShippingItem> ShippingItems { get; set; }
}
