using ContatosApp.Models;

namespace ContatosApp.Repositorio
{
	public interface IContatoRepositorio
	{
		ContatoModel Adicionar(ContatoModel contato);
	}
}
