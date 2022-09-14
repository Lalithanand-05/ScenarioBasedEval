using Microsoft.EntityFrameworkCore;
using ExperiencePost1.Models;
namespace ExperiencePost1.Models
{
			public class EmployeeDbContext : DbContext
		{
			public DbSet<Employee> employees { get; set; }
			public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
			: base(options) { }
		}
	}

