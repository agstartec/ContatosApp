using ContatosApp.Models;

namespace ContatosApp.Repositorio
{
	public interface IUsuariosRepositorio
	{
		UsuarioModel Autenticar(string usuario);
	}
}
