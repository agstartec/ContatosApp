using ContatosApp.Data;
using ContatosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosApp.Repositorio
{
	public class UsuariosRepositorio : IUsuariosRepositorio
	{
		private readonly DatabaseContext _context;
		public UsuariosRepositorio(DatabaseContext context)
		{
			_context = context;
		}

        public UsuarioModel Autenticar(string usuario)
        {
			return _context.usuarios.FirstOrDefault(x => x.usuario == usuario);
        }
    }
}
