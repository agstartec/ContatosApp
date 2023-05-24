using ContatosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosApp.Data
{
	public class DatabaseContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public DatabaseContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			// connect to mysql with connection string from app settings
			var connectionString = Configuration.GetConnectionString("WebApiDatabase");
			options.UseMySQL(connectionString);
		}
		public DbSet<ContatoModel> contatos { get; set; }
	}
}
