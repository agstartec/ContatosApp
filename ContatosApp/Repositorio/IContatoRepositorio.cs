using ContatosApp.Models;

namespace ContatosApp.Repositorio
{
	public interface IContatoRepositorio
	{
		List<ContatoModel> ListarTodos();
		ContatoModel Adicionar(ContatoModel contato);
	}
}
