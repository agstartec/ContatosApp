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

		public ContatoModel ListarContato(int id)
		{
			return _context.contatos.FirstOrDefault(x => x.id == id);
		}

		public ContatoModel Editar(ContatoModel contato)
		{
			ContatoModel contatoDb = ListarContato(contato.id);			
			if (contatoDb == null) throw new System.Exception("Erro interno: falha na atualização do cliente");

			contatoDb.nome = contato.nome;
			contatoDb.telefone = contato.telefone;
			contatoDb.email = contato.email;

			_context.contatos.Update(contatoDb);
			_context.SaveChanges();

			return contatoDb;
        }

		public bool Apagar(int id)
		{
			ContatoModel contatoDb = ListarContato(id);
			if (contatoDb == null) throw new System.Exception("Erro interno: falha ao deletar o cliente");
			
			_context.contatos.Remove(contatoDb);
			_context.SaveChanges();

			return true;
		}
	}
}
