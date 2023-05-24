using ContatosApp.Models;

namespace ContatosApp.Repositorio
{
	public interface IContatoRepositorio
	{
		List<ContatoModel> ListarTodos();
		ContatoModel ListarContato(int id);
		ContatoModel Adicionar(ContatoModel contato);
		ContatoModel Editar(ContatoModel contato);
	}
}
