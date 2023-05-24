using ContatosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosApp.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }
		public DbSet<ContatoModel> contatos { get; set; }
	}
}
