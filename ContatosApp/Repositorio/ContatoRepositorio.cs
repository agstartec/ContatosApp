using ContatosApp.Data;
using ContatosApp.Models;

namespace ContatosApp.Repositorio
{
	public class ContatoRepositorio : IContatoRepositorio
	{
		private readonly DatabaseContext _context;
		public ContatoRepositorio(DatabaseContext context)
        {
            _context = context;
        }
		public List<ContatoModel> ListarTodos()
		{
			return _context.contatos.ToList();
		}
		public ContatoModel Adicionar(ContatoModel contato)
		{
			_context.contatos.Add(contato);
			_context.SaveChanges();
			return contato;
		}


	}
}
